
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public enum ASTSubtractionOperatorNodeInputLeftDiscriminatorType
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
    public static class ASTSubtractionOperatorNodeInputLeftDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ASTSubtractionOperatorNodeInputLeftDiscriminatorType value)
        {
            return value switch
            {
                ASTSubtractionOperatorNodeInputLeftDiscriminatorType.AddOperator => "add_operator",
                ASTSubtractionOperatorNodeInputLeftDiscriminatorType.AndOperator => "and_operator",
                ASTSubtractionOperatorNodeInputLeftDiscriminatorType.BooleanLiteral => "boolean_literal",
                ASTSubtractionOperatorNodeInputLeftDiscriminatorType.ConditionalOperator => "conditional_operator",
                ASTSubtractionOperatorNodeInputLeftDiscriminatorType.DivOperator => "div_operator",
                ASTSubtractionOperatorNodeInputLeftDiscriminatorType.DynamicVariable => "dynamic_variable",
                ASTSubtractionOperatorNodeInputLeftDiscriminatorType.EqOperator => "eq_operator",
                ASTSubtractionOperatorNodeInputLeftDiscriminatorType.GtOperator => "gt_operator",
                ASTSubtractionOperatorNodeInputLeftDiscriminatorType.GteOperator => "gte_operator",
                ASTSubtractionOperatorNodeInputLeftDiscriminatorType.Llm => "llm",
                ASTSubtractionOperatorNodeInputLeftDiscriminatorType.LtOperator => "lt_operator",
                ASTSubtractionOperatorNodeInputLeftDiscriminatorType.LteOperator => "lte_operator",
                ASTSubtractionOperatorNodeInputLeftDiscriminatorType.MulOperator => "mul_operator",
                ASTSubtractionOperatorNodeInputLeftDiscriminatorType.NeqOperator => "neq_operator",
                ASTSubtractionOperatorNodeInputLeftDiscriminatorType.NumberLiteral => "number_literal",
                ASTSubtractionOperatorNodeInputLeftDiscriminatorType.OrOperator => "or_operator",
                ASTSubtractionOperatorNodeInputLeftDiscriminatorType.StringLiteral => "string_literal",
                ASTSubtractionOperatorNodeInputLeftDiscriminatorType.SubOperator => "sub_operator",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ASTSubtractionOperatorNodeInputLeftDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "add_operator" => ASTSubtractionOperatorNodeInputLeftDiscriminatorType.AddOperator,
                "and_operator" => ASTSubtractionOperatorNodeInputLeftDiscriminatorType.AndOperator,
                "boolean_literal" => ASTSubtractionOperatorNodeInputLeftDiscriminatorType.BooleanLiteral,
                "conditional_operator" => ASTSubtractionOperatorNodeInputLeftDiscriminatorType.ConditionalOperator,
                "div_operator" => ASTSubtractionOperatorNodeInputLeftDiscriminatorType.DivOperator,
                "dynamic_variable" => ASTSubtractionOperatorNodeInputLeftDiscriminatorType.DynamicVariable,
                "eq_operator" => ASTSubtractionOperatorNodeInputLeftDiscriminatorType.EqOperator,
                "gt_operator" => ASTSubtractionOperatorNodeInputLeftDiscriminatorType.GtOperator,
                "gte_operator" => ASTSubtractionOperatorNodeInputLeftDiscriminatorType.GteOperator,
                "llm" => ASTSubtractionOperatorNodeInputLeftDiscriminatorType.Llm,
                "lt_operator" => ASTSubtractionOperatorNodeInputLeftDiscriminatorType.LtOperator,
                "lte_operator" => ASTSubtractionOperatorNodeInputLeftDiscriminatorType.LteOperator,
                "mul_operator" => ASTSubtractionOperatorNodeInputLeftDiscriminatorType.MulOperator,
                "neq_operator" => ASTSubtractionOperatorNodeInputLeftDiscriminatorType.NeqOperator,
                "number_literal" => ASTSubtractionOperatorNodeInputLeftDiscriminatorType.NumberLiteral,
                "or_operator" => ASTSubtractionOperatorNodeInputLeftDiscriminatorType.OrOperator,
                "string_literal" => ASTSubtractionOperatorNodeInputLeftDiscriminatorType.StringLiteral,
                "sub_operator" => ASTSubtractionOperatorNodeInputLeftDiscriminatorType.SubOperator,
                _ => null,
            };
        }
    }
}