
namespace WaterBuilderLibrary {
    public class Director {
        private IBuilder _builder;
        public Director(IBuilder builder) {
            _builder = builder;
        }

        /// <summary>
        /// 
        /// </summary>
        public void Constract() {
            _builder.AddSolute(100);
            _builder.AddSolute(40);
            _builder.AbandonSolution(70);
            _builder.AddSolvent(100);
            _builder.AddSolute(15);
        }

    }
}
