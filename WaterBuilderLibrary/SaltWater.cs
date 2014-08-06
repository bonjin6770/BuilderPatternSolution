
namespace WaterBuilderLibrary {

    /// <summary>
    /// 食塩水を表すValueObject
    /// </summary>
    public class SaltWater {

        /// <summary>
        /// 塩
        /// </summary>
        public double salt;

        /// <summary>
        /// 水
        /// </summary>
        public double water;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="salt"></param>
        /// <param name="water"></param>
        public SaltWater(double salt, double water) {
            this.salt = salt;
            this.water = water;
        }

    }
}
