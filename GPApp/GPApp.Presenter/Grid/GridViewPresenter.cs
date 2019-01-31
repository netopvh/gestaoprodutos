﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GPApp.Presenter.Grid
{
    public class GridViewPresenter<T>
    {
        #region Membros

        private GridConfig<T> _gridInfo;
        public IGridViewFiltro GridView;
        public event EventHandler<Boolean> FiltrouEvent;

        #endregion

        #region Construtor

        public GridViewPresenter(IGridViewFiltro gridView)
        {
            GridView = gridView;
            GridView.Inicializa = OnInicializaGrid;
            GridView.GetValue = OnGetValueGrid;
            GridView.OrderAction = OnOrderAction;
            GridView.FiltrarAcion = OnFiltrarAction;
            GridView.AtivarFiltroAction = OnAtivarAction;
            GridView.ErroPagincaoAction = OnErroPaginacaoAction;
        }

        #endregion

        #region Ações

        private Task<bool> OnInicializaGrid()
        {
            var tarefa = Task.Run(() =>
            {
                _gridInfo.Cache.CarregarDuasPaginas();
                return true;
            });

            var continueUi = tarefa.ContinueWith(async (t) =>
            {
                var continuar = await t;
                if (!continuar) return;

                AtualizaRowGridView();

            }, TaskScheduler.FromCurrentSynchronizationContext());

            return tarefa;
        }

        private object OnGetValueGrid(int indice, string nomePropriedade)
        {
            return _gridInfo.Cache.RecuperarValorDoItem(indice, nomePropriedade);
        }

        private void OnErroPaginacaoAction()
        {
            _gridInfo.Cache.LimparCache();
            GridView.AtualizarDesign();
        }

        private async void OnFiltrarAction(string textoPesquisa)
        {
            GridView.FiltroAtivo = !string.IsNullOrWhiteSpace(textoPesquisa);
            await Filtra(textoPesquisa);
            GridView.ExibePainelPesquisa(false);
            FiltrouEvent?.Invoke(this, GridView.FiltroAtivo);
        }

        private void OnOrderAction(string nomePropriedade)
        {
            _gridInfo.DataRetriever.Order = nomePropriedade;
            _gridInfo.Cache.CarregarDuasPaginas();
            GridView.AtualizarDesign();
        }

        #endregion

        #region Métodos

        public void AtualizaRowGridView()
        {
            GridView.SetNumeroRegistros(_gridInfo.DataRetriever.NumeroRegistros);
            GridView.AtualizarDesign();
        }

        public void SetColunaChave(string chave)
        {
            GridView.ColunaChave = chave;
        }

        public void SetGridInfo(GridConfig<T> gridInfo)
        {
            _gridInfo = gridInfo;
            GridView.SetColunas(_gridInfo.ColumnsInfo);
            GridView.DefineColunaModoLeitura(_gridInfo.ModoLeitura);
            GridView.ColunaChave = gridInfo.ColunaChave;
            GridView.SetCores();
        }

        public Task<bool> LoadAsync()
        {
            return GridView.Inicializa();
        }

        public async void LimpaFiltro()
        {
            await Filtra(string.Empty);
            GridView.FiltroAtivo = false;
            FiltrouEvent(this, false);
        }

        internal Task<IList<T>> GetItensAsync()
        {
            return _gridInfo.DataRetriever.GetItensAsync();
        }

        internal IList<M> GetIds<M>()
        {
            return _gridInfo.DataRetriever.Getids<M>();
        }

        private async Task Filtra(string textoPesquisa)
        {
            _gridInfo.DataRetriever.Pesquisa = textoPesquisa;
            GridView.SetNumeroRegistros(0);
            await LoadAsync();
        }

        private  void OnAtivarAction()
        {
            if (GridView.FiltroAtivo)
            {
                LimpaFiltro();
            }

            GridView.FiltroAtivo = !GridView.FiltroAtivo;
            GridView.ExibePainelPesquisa(GridView.FiltroAtivo);
        }

        #endregion
    }
}