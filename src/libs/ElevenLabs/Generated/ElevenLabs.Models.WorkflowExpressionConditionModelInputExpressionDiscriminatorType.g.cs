
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public enum WorkflowExpressionConditionModelInputExpressionDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        AddOperator,
        /// <summary>
        /// 
        /// </summary>
        AndOperator,
        /// <summary>
        /// 
        /// </summary>
        BooleanLiteral,
        /// <summary>
        /// 
        /// </summary>
        ConditionalOperator,
        /// <summary>
        /// 
        /// </summary>
        DivOperator,
        /// <summary>
        /// 
        /// </summary>
        DynamicVariable,
        /// <summary>
        /// 
        /// </summary>
        EqOperator,
        /// <summary>
        /// 
        /// </summary>
        GtOperator,
        /// <summary>
        /// 
        /// </summary>
        GteOperator,
        /// <summary>
        /// 
        /// </summary>
        Llm,
        /// <summary>
        /// 
        /// </summary>
        LtOperator,
        /// <summary>
        /// 
        /// </summary>
        LteOperator,
        /// <summary>
        /// 
        /// </summary>
        MulOperator,
        /// <summary>
        /// 
        /// </summary>
        NeqOperator,
        /// <summary>
        /// 
        /// </summary>
        NumberLiteral,
        /// <summary>
        /// 
        /// </summary>
        OrOperator,
        /// <summary>
        /// 
        /// </summary>
        StringLiteral,
        /// <summary>
        /// 
        /// </summary>
        SubOperator,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WorkflowExpressionConditionModelInputExpressionDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WorkflowExpressionConditionModelInputExpressionDiscriminatorType value)
        {
            return value switch
            {
                WorkflowExpressionConditionModelInputExpressionDiscriminatorType.AddOperator => "add_operator",
                WorkflowExpressionConditionModelInputExpressionDiscriminatorType.AndOperator => "and_operator",
                WorkflowExpressionConditionModelInputExpressionDiscriminatorType.BooleanLiteral => "boolean_literal",
                WorkflowExpressionConditionModelInputExpressionDiscriminatorType.ConditionalOperator => "conditional_operator",
                WorkflowExpressionConditionModelInputExpressionDiscriminatorType.DivOperator => "div_operator",
                WorkflowExpressionConditionModelInputExpressionDiscriminatorType.DynamicVariable => "dynamic_variable",
                WorkflowExpressionConditionModelInputExpressionDiscriminatorType.EqOperator => "eq_operator",
                WorkflowExpressionConditionModelInputExpressionDiscriminatorType.GtOperator => "gt_operator",
                WorkflowExpressionConditionModelInputExpressionDiscriminatorType.GteOperator => "gte_operator",
                WorkflowExpressionConditionModelInputExpressionDiscriminatorType.Llm => "llm",
                WorkflowExpressionConditionModelInputExpressionDiscriminatorType.LtOperator => "lt_operator",
                WorkflowExpressionConditionModelInputExpressionDiscriminatorType.LteOperator => "lte_operator",
                WorkflowExpressionConditionModelInputExpressionDiscriminatorType.MulOperator => "mul_operator",
                WorkflowExpressionConditionModelInputExpressionDiscriminatorType.NeqOperator => "neq_operator",
                WorkflowExpressionConditionModelInputExpressionDiscriminatorType.NumberLiteral => "number_literal",
                WorkflowExpressionConditionModelInputExpressionDiscriminatorType.OrOperator => "or_operator",
                WorkflowExpressionConditionModelInputExpressionDiscriminatorType.StringLiteral => "string_literal",
                WorkflowExpressionConditionModelInputExpressionDiscriminatorType.SubOperator => "sub_operator",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WorkflowExpressionConditionModelInputExpressionDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "add_operator" => WorkflowExpressionConditionModelInputExpressionDiscriminatorType.AddOperator,
                "and_operator" => WorkflowExpressionConditionModelInputExpressionDiscriminatorType.AndOperator,
                "boolean_literal" => WorkflowExpressionConditionModelInputExpressionDiscriminatorType.BooleanLiteral,
                "conditional_operator" => WorkflowExpressionConditionModelInputExpressionDiscriminatorType.ConditionalOperator,
                "div_operator" => WorkflowExpressionConditionModelInputExpressionDiscriminatorType.DivOperator,
                "dynamic_variable" => WorkflowExpressionConditionModelInputExpressionDiscriminatorType.DynamicVariable,
                "eq_operator" => WorkflowExpressionConditionModelInputExpressionDiscriminatorType.EqOperator,
                "gt_operator" => WorkflowExpressionConditionModelInputExpressionDiscriminatorType.GtOperator,
                "gte_operator" => WorkflowExpressionConditionModelInputExpressionDiscriminatorType.GteOperator,
                "llm" => WorkflowExpressionConditionModelInputExpressionDiscriminatorType.Llm,
                "lt_operator" => WorkflowExpressionConditionModelInputExpressionDiscriminatorType.LtOperator,
                "lte_operator" => WorkflowExpressionConditionModelInputExpressionDiscriminatorType.LteOperator,
                "mul_operator" => WorkflowExpressionConditionModelInputExpressionDiscriminatorType.MulOperator,
                "neq_operator" => WorkflowExpressionConditionModelInputExpressionDiscriminatorType.NeqOperator,
                "number_literal" => WorkflowExpressionConditionModelInputExpressionDiscriminatorType.NumberLiteral,
                "or_operator" => WorkflowExpressionConditionModelInputExpressionDiscriminatorType.OrOperator,
                "string_literal" => WorkflowExpressionConditionModelInputExpressionDiscriminatorType.StringLiteral,
                "sub_operator" => WorkflowExpressionConditionModelInputExpressionDiscriminatorType.SubOperator,
                _ => null,
            };
        }
    }
}