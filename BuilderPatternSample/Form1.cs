using System;
using System.Windows.Forms;
using WaterBuilderLibrary;
using System.Text;

namespace BuilderPatternSample {
    /// <summary>
    /// GoFのBuilderパターンを実装。
    /// 以下を参考
    /// http://www.techscore.com/tech/DesignPattern/Builder.html
    /// </summary>
    public partial class Form1 : Form {

        public Form1() {
            InitializeComponent();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saltWaterBuildButton_Click(object sender, EventArgs e) {
            var saltWaterBuilder = new SaltWaterBuilder();
            var director = new Director(saltWaterBuilder);
            director.Constract();
            var saltWater = saltWaterBuilder.GetResult() as SaltWater;
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(string.Format("食塩 = {0}", saltWater.salt.ToString()));
            sb.AppendLine(string.Format("水 = {0}", saltWater.water.ToString()));
            ShowResult(sb.ToString());
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="text"></param>
        private void ShowResult(string text) {
            resultTextBox.Text += "結果を表示↓";
            resultTextBox.Text += System.Environment.NewLine;
            resultTextBox.Text += text;
        }
    }
}
