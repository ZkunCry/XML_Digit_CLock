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
        static View[,,] ViewList = null;
        Color colorOn = Color.SpringGreen;
        Color colorOff = Color.Default;

        static readonly int[,,] numberPatterns = new int[10, 5, 3]
        {
        {
            { 0, 1, 0}, 
            { 1, 0, 1}, 
            { 0,0,0}, 
            { 1, 0,1},//0
            { 0,1,0}
        },
        {
            { 0,0,0}, 
            { 0, 0,1}, 
            { 0,0,0}, //1
            { 0, 0, 1},
            { 0, 0,0}
        },
        {
            { 0, 1,0}, 
            { 0,0,1}, 
            { 0, 1, 0}, //2
            { 1, 0,0},
            { 0, 1,0 }
        },
        {
            {0,1,0},
            {0,0,1},
            {0,1,0},
            {0,0,1},//3
            {0,1,0}
        },
        {
            { 0, 0, 0},
            { 1, 0, 1},
            { 0, 1, 0},//4
            { 0, 0, 1},
            { 0,0,0}
        },
        {
            { 0,1,0},
            { 1, 0, 0},
            { 0,1,0},//5
            { 0,0,1},
            { 0,1,0}
        },
        {
            { 0,1,0},
            { 1, 0, 0},
            { 0, 1, 0},//6
            { 1, 0, 1},
            { 0,1,0}
        },
        {
            { 0,1,0},
            { 0, 0, 1},
            { 0, 0, 0},//7
            { 0, 0, 1},
            { 0, 0, 0}
        },
        {
            { 0, 1, 0},
            { 1, 0, 1},
            { 0, 1, 0},   //8
            { 1, 0, 1},
            { 0, 1, 0}
        },
        {
            { 0, 1, 0},
            { 1, 0, 1},
            { 0, 1, 0}, //9
            { 0, 0, 1},
            { 0, 1, 0}
        },};
        
        
       private  bool OnTimer()
        {
            DateTime dateTime = DateTime.Now;
            int hour = (dateTime.Hour);
            SetDotMatrix(0, hour / 10);
            SetDotMatrix(1, hour % 10);
            SetDotMatrix(2, dateTime.Minute / 10);
            SetDotMatrix(3, dateTime.Minute % 10);
            SetDotMatrix(4, dateTime.Second / 10);
            SetDotMatrix(5, dateTime.Second % 10);
            return true;
        }
        public MainPage()
        {
            InitializeComponent();
            View[,,] ViewColumns = new View[6, 5, 3]
            {
            {
            { gridlayout.Children[0], gridlayout.Children[1], gridlayout.Children[2]},
            {gridlayout.Children[24] , gridlayout.Children[25], gridlayout.Children[26]},
            { gridlayout.Children[48],gridlayout.Children[49],gridlayout.Children[50]},
            { gridlayout.Children[72], gridlayout.Children[73],gridlayout.Children[74]},
            { gridlayout.Children[96],gridlayout.Children[97],gridlayout.Children[98]}
            },
        {
            { gridlayout.Children[3], gridlayout.Children[4], gridlayout.Children[5]},
            {gridlayout.Children[27] , gridlayout.Children[28], gridlayout.Children[29]},
            { gridlayout.Children[51],gridlayout.Children[52],gridlayout.Children[53]},
            { gridlayout.Children[75], gridlayout.Children[76],gridlayout.Children[77]},
            { gridlayout.Children[99],gridlayout.Children[100],gridlayout.Children[101]}
        },
        {
            { gridlayout.Children[6], gridlayout.Children[10], gridlayout.Children[11]},
            {gridlayout.Children[33] , gridlayout.Children[34], gridlayout.Children[35]},
            { gridlayout.Children[57],gridlayout.Children[58],gridlayout.Children[59]},
            { gridlayout.Children[81], gridlayout.Children[82],gridlayout.Children[83]},
            { gridlayout.Children[105],gridlayout.Children[106],gridlayout.Children[107]}
        },
        {
            { gridlayout.Children[12], gridlayout.Children[13], gridlayout.Children[14]},
            {gridlayout.Children[36] , gridlayout.Children[37], gridlayout.Children[38]},
            { gridlayout.Children[60],gridlayout.Children[61],gridlayout.Children[62]},
            { gridlayout.Children[84], gridlayout.Children[85],gridlayout.Children[86]},
            { gridlayout.Children[108],gridlayout.Children[109],gridlayout.Children[110]}
        },
        {
            { gridlayout.Children[18], gridlayout.Children[19], gridlayout.Children[20]},
            {gridlayout.Children[42] , gridlayout.Children[43], gridlayout.Children[44]},
            { gridlayout.Children[66],gridlayout.Children[67],gridlayout.Children[68]},
            { gridlayout.Children[90], gridlayout.Children[91],gridlayout.Children[92]},
            { gridlayout.Children[114],gridlayout.Children[115],gridlayout.Children[116]}
        },
        {
            { gridlayout.Children[21], gridlayout.Children[22], gridlayout.Children[23]},
            {gridlayout.Children[45] , gridlayout.Children[46], gridlayout.Children[47]},
            { gridlayout.Children[69],gridlayout.Children[70],gridlayout.Children[71]},
            { gridlayout.Children[93], gridlayout.Children[94],gridlayout.Children[95]},
            { gridlayout.Children[117],gridlayout.Children[118],gridlayout.Children[119]}
        },};
            ViewList = ViewColumns;

            Device.StartTimer(TimeSpan.FromSeconds(1), OnTimer);
            OnTimer();
        }
        void SetDotMatrix(int index, int digit)
        {
            for (int row = 0; row < 5; row++)
                for (int col = 0; col < 3; col++)
                {
                    bool isOn = numberPatterns[digit, row, col] == 1;
                    Color color = isOn ? colorOn : colorOff;
                    ViewList[index, row, col].BackgroundColor = color;
                }
        }
    }
}


