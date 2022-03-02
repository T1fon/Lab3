namespace Lab3
{
    public class R_N_E : Exception
    {
        public R_N_E() { }
        public R_N_E(string text) : base(text) { }
        public R_N_E(string text, R_N_E inner) : base(text, inner) { }
        protected R_N_E(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
