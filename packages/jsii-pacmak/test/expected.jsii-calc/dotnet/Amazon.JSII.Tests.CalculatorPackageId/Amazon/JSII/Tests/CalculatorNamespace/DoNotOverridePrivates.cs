using Amazon.JSII.Runtime.Deputy;

namespace Amazon.JSII.Tests.CalculatorNamespace
{
    /// <remarks>
    /// <strong>Stability</strong>: Experimental
    /// </remarks>
    [JsiiClass(nativeType: typeof(Amazon.JSII.Tests.CalculatorNamespace.DoNotOverridePrivates), fullyQualifiedName: "jsii-calc.DoNotOverridePrivates")]
    public class DoNotOverridePrivates : DeputyBase
    {
        public DoNotOverridePrivates(): base(new DeputyProps(new object[]{}))
        {
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DoNotOverridePrivates(ByRefValue reference): base(reference)
        {
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DoNotOverridePrivates(DeputyProps props): base(props)
        {
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiMethod(name: "changePrivatePropertyValue", parametersJson: "[{\"name\":\"newValue\",\"type\":{\"primitive\":\"string\"}}]")]
        public virtual void ChangePrivatePropertyValue(string newValue)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(string)}, new object[]{newValue});
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiMethod(name: "privateMethodValue", returnsJson: "{\"type\":{\"primitive\":\"string\"}}")]
        public virtual string PrivateMethodValue()
        {
            return InvokeInstanceMethod<string>(new System.Type[]{}, new object[]{});
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiMethod(name: "privatePropertyValue", returnsJson: "{\"type\":{\"primitive\":\"string\"}}")]
        public virtual string PrivatePropertyValue()
        {
            return InvokeInstanceMethod<string>(new System.Type[]{}, new object[]{});
        }
    }
}
