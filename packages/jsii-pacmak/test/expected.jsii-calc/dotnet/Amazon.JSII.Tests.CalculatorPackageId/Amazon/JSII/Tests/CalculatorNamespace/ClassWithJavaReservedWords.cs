using Amazon.JSII.Runtime.Deputy;

namespace Amazon.JSII.Tests.CalculatorNamespace
{
    /// <remarks>
    /// <strong>Stability</strong>: Experimental
    /// </remarks>
    [JsiiClass(nativeType: typeof(Amazon.JSII.Tests.CalculatorNamespace.ClassWithJavaReservedWords), fullyQualifiedName: "jsii-calc.ClassWithJavaReservedWords", parametersJson: "[{\"name\":\"int\",\"type\":{\"primitive\":\"string\"}}]")]
    public class ClassWithJavaReservedWords : DeputyBase
    {
        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        public ClassWithJavaReservedWords(string @int): base(new DeputyProps(new object[]{@int}))
        {
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ClassWithJavaReservedWords(ByRefValue reference): base(reference)
        {
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ClassWithJavaReservedWords(DeputyProps props): base(props)
        {
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiMethod(name: "import", returnsJson: "{\"type\":{\"primitive\":\"string\"}}", parametersJson: "[{\"name\":\"assert\",\"type\":{\"primitive\":\"string\"}}]")]
        public virtual string Import(string assert)
        {
            return InvokeInstanceMethod<string>(new System.Type[]{typeof(string)}, new object[]{assert});
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiProperty(name: "int", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Int
        {
            get => GetInstanceProperty<string>();
        }
    }
}
