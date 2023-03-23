using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace testxamarin
{
    public partial class MainPage : ContentPage
    {
        static readonly int[,] Colon = new int[5, 3]
        {
            { 0, 0,0 },
            { 0, 1,0 },
            { 0, 0,0 },
            { 0, 1,0 },
            { 0, 0,0 }
        };
        static readonly int[,,] numberPatterns = new int[10, 5, 3]
    {
        {
            { 0, 1, 0}, { 1, 0, 1}, { 0,0,0}, { 1, 0,1},{ 0,1,0}
        },
        {
            { 0,0,0}, { 0, 0,1}, { 0,0,0}, { 0, 0, 1},{ 0, 0,0}
        },
        {
            { 0, 1,0}, { 0,0,1}, { 0, 1, 0}, { 1, 0,0},
            { 0, 1,0 }
        },
        {
            { 0,1,0}, 
            {0,0,1}, 
            { 0, 1, 0}, 
            { 0, 0, 1},
            { 0,1,0}
        },
        {
            { 0, 0, 0}, 
            { 1, 0, 1}, 
            { 0, 1, 0}, 
            { 0, 0, 1},
            { 0,0,0}
        },
        {
            { 0,1,0}, 
            { 1, 0, 0}, 
            { 0,1,0}, 
            { 0,0,1},
            { 0,1,0}
        },
        {
            { 0,1,0}, 
            { 1, 0, 0}, 
            { 0, 1, 0}, 
            { 1, 0, 1},
            { 0,1,0}
        },
        {
            { 0,1,0}, 
            { 0, 0, 1}, 
            { 0, 0, 0}, 
            { 0, 0, 1},
            { 0, 0, 0}
        },
        {
            { 0, 1, 0}, 
            { 1, 0, 1}, 
            { 0, 1, 0}, 
            { 1, 0, 1},
            { 0, 1, 0}
        },
        {
            { 0, 1, 0}, 
            { 1, 0, 1}, 
            { 0, 1, 0}, 
            { 0, 0, 1},
            { 0, 1, 0}
        },
    };
        public MainPage()
        {
            InitializeComponent();
        }
    }
}


