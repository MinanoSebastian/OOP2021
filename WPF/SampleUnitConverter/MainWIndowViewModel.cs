﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SampleUnitConverter
{
    class MainWIndowViewModel : ViewModel
    {
        //自動実装プロパティ
        //public double MetricValue { get; set; }
        //public double ImperiaValue { get; set; }


        private double metricValue;
        private double imperialValue;

        // ▲ボタンで呼ばれるコマンド
        public ICommand ImperialUnitToMetric { get; private set; }

        // ▼ボタンで呼ばれるコマンド
        public ICommand MetricToImperialUnit { get; private set; }

        // 上のComboBoxで選択されている値
        public MetricUnit CurrentMetricUnit { get; set; }

        // 下のComboBoxで選択されている値
        public ImperialUnit CurrentImperialUnit { get; set; }

        public double MetricValue
        {
            get { return this.metricValue; }
            set
            {
                this.metricValue = value;
                this.OnPropertyChanged(); //Viewへ通知
            }
        }

        public double ImperialValue
        {
            get { return this.imperialValue; }
            set
            {
                this.imperialValue = value;
                this.OnPropertyChanged();  //Viewへ通知
            }
        }

        // コンストラクタ
        public MainWIndowViewModel()
        {
            this.CurrentMetricUnit = MetricUnit.Units.First(); // メートル単位
            this.CurrentImperialUnit = ImperialUnit.Units.First();  // ヤード単位

            this.MetricToImperialUnit = 
                new DelegateCommand(
                () => this.ImperialValue = 
                 this.CurrentImperialUnit.FromMetricUnit(this.CurrentMetricUnit, this.MetricValue));
        }
    }
}
