using System;
using MvvmHelpers;
using AppliedActivity1.Models;
using AppliedActivity1.Services;
using MvvmHelpers.Commands;

namespace AppliedActivity1.ViewModels
{
    internal class GOTListViewModel
    {
        public IGOTDataStore<GOT> DataStore => DependencyService.Get<IGOTDataStore<GOT>>();
        public ObservableRangeCollection<GOT> GOTs { get; set; }
        public AsyncCommand PageAppearingCommand { get; }

        public GOTListViewModel()
        {
            GOTs = new ObservableRangeCollection<GOT>();
            PageAppearingCommand = new AsyncCommand(PageAppearing);
        }

        public async Task Refresh()
        {
            var employees = await DataStore.GetGOTAsync(10);

            GOTs.AddRange(employees);
        }

        async Task PageAppearing()
        {
            await Refresh();
        }
    }
}