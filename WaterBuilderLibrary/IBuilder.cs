namespace WaterBuilderLibrary {
    /// <summary>
    /// 
    /// </summary>
    public interface IBuilder {
        /// <summary>
        /// 溶質を追加する
        /// </summary>
        /// <param name="soluteAmmount"></param>
        void AddSolute(double soluteAmmount);
        /// <summary>
        /// 溶媒を追加
        /// </summary>
        /// <param name="solventAmount"></param>
        void AddSolvent(double solventAmount);
        /// <summary>
        /// 溶液を捨てる
        /// </summary>
        /// <param name="solutionAmount"></param>
        void AbandonSolution(double saltWaterAmount);
        /// <summary>
        /// 生成物を取得
        /// </summary>
        /// <returns></returns>
        object GetResult();
    }
}
