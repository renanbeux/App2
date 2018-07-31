﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App2.TipoPagina.Master
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Master : MasterDetailPage
	{
		public Master ()
		{
			InitializeComponent ();
		}

        private void MudarPagina1(object sender, EventArgs args)
        {
            Detail = new NavigationPage(new Navigation.Pagina1());
            IsPresented = false; // Oculta o menu quando clicado;
        }

        private void MudarPagina2(object sender, EventArgs args)
        {
            Detail = new Navigation.Pagina2();
            IsPresented = false; // Oculta o menu quando clicado;
        }

        private void MudarPagina3(object sender, EventArgs args)
        {
            Detail = new Conteudo();
            IsPresented = false; // Oculta o menu quando clicado;
        }

    }
}