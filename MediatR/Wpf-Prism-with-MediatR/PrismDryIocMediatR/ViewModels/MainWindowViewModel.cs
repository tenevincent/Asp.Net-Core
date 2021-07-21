using MediatR;
using Prism.Commands;
using Prism.Mvvm;
using PrismDryIocMediatR.Commands;
using System;

namespace PrismDryIocMediatR.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        private string _title = "Prism Application";
        private readonly IMediator mediator;

        public DelegateCommand AddCommand { get; }

        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        public MainWindowViewModel(IMediator mediator)
        {
            this.mediator = mediator;

            this.AddCommand = new DelegateCommand(OnAddCommand);
        }

        private async void OnAddCommand()
        {
          var result = await  this.mediator.Send(new DeleteAccountCommand());
       
        }
    }
}
