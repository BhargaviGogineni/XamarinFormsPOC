using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Input;
using FreshMvvm;
using PropertyChanged;
using Refit;
using Xamarin.Forms;
using XamarinFormsPOC.Models.Response;
using XamarinFormsPOC.Services;

namespace XamarinFormsPOC.PageModels
{
    [AddINotifyPropertyChangedInterface]
    public class SpeciesListPageModel : FreshBasePageModel
    {
        #region Properties

        public ISpeciesApi _speciesApi;

        public List<Species> SpeciesList { get; set; }

        public bool Loadingvisible { get; set; } = false;

        public bool isRefreshing { get; set; } = false;

        public string PageTitle { get; set; }

        #endregion

        #region CTOR

        public SpeciesListPageModel(ISpeciesApi speciesApi)
        {
            _speciesApi = speciesApi;
        }

        #endregion

        #region Methods

        public override void Init(object initData)
        {
            base.Init(initData);
        }

        protected async override void ViewIsAppearing(object sender, EventArgs e)
        {
            base.ViewIsAppearing(sender, e);

            Loadingvisible = true;

            await LoadSpecies();
        }


        //Loading Data

        private async Task LoadSpecies()
        {
            var data = await _speciesApi.GetSpecies();

            if (data != null && data.rows != null)
            {
                SpeciesList = data.rows;
                PageTitle = data.title;
            }

            Loadingvisible = false;
        }

        public ICommand RefreshData
        {
            get
            {
                return new Command(async () =>
                {
                    isRefreshing = true;
                    await LoadSpecies();
                    isRefreshing = false;
                });
            }
        }


        public Command SpeciesTapped
        {
            get
            {
                return new Command((data) =>
                {
                    var species = (Species)data;
                    CoreMethods.DisplayAlert("Canadian Species", species.title + "", "Ok");
                });
            }
        }

        #endregion

    }
}
