
namespace WaterBuilderLibrary {
    public class SaltWaterBuilder : IBuilder {
        /// <summary>
        /// 
        /// </summary>
        private SaltWater _saltWater;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public SaltWaterBuilder() {
            _saltWater = new SaltWater(0, 0);
        }

        /// <summary>
        /// 溶質を追加する
        /// </summary>
        /// <param name="soluteAmmount"></param>
        public void AddSolute(double soluteAmmount) {
            _saltWater.salt += soluteAmmount;
        }
        /// <summary>
        /// 溶媒を追加
        /// </summary>
        /// <param name="solventAmount"></param>
        public void AddSolvent(double solventAmount) {
            _saltWater.water += solventAmount;
        }
        /// <summary>
        /// 溶液を捨てる
        /// </summary>
        /// <param name="solutionAmount"></param>
        public void AbandonSolution(double saltWaterAmount) {
            double saltDelta =
                saltWaterAmount * (_saltWater.salt / (_saltWater.salt + _saltWater.water));
            _saltWater.salt -= saltDelta;

            double waterDelta =
                saltWaterAmount * (_saltWater.water / (_saltWater.salt + _saltWater.water));
            _saltWater.water -= waterDelta;
        }

        /// <summary>
        /// 生成物を取得
        /// </summary>
        /// <returns></returns>
        public object GetResult() {
            return _saltWater;
        }
    }
}
