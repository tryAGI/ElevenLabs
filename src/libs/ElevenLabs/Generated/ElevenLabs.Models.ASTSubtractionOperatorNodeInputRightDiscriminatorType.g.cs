
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public enum ASTSubtractionOperatorNodeInputRightDiscriminatorType
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
    public static class ASTSubtractionOperatorNodeInputRightDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ASTSubtractionOperatorNodeInputRightDiscriminatorType value)
        {
            return value switch
            {
                ASTSubtractionOperatorNodeInputRightDiscriminatorType.AddOperator => "add_operator",
                ASTSubtractionOperatorNodeInputRightDiscriminatorType.AndOperator => "and_operator",
                ASTSubtractionOperatorNodeInputRightDiscriminatorType.BooleanLiteral => "boolean_literal",
                ASTSubtractionOperatorNodeInputRightDiscriminatorType.ConditionalOperator => "conditional_operator",
                ASTSubtractionOperatorNodeInputRightDiscriminatorType.DivOperator => "div_operator",
                ASTSubtractionOperatorNodeInputRightDiscriminatorType.DynamicVariable => "dynamic_variable",
                ASTSubtractionOperatorNodeInputRightDiscriminatorType.EqOperator => "eq_operator",
                ASTSubtractionOperatorNodeInputRightDiscriminatorType.GtOperator => "gt_operator",
                ASTSubtractionOperatorNodeInputRightDiscriminatorType.GteOperator => "gte_operator",
                ASTSubtractionOperatorNodeInputRightDiscriminatorType.Llm => "llm",
                ASTSubtractionOperatorNodeInputRightDiscriminatorType.LtOperator => "lt_operator",
                ASTSubtractionOperatorNodeInputRightDiscriminatorType.LteOperator => "lte_operator",
                ASTSubtractionOperatorNodeInputRightDiscriminatorType.MulOperator => "mul_operator",
                ASTSubtractionOperatorNodeInputRightDiscriminatorType.NeqOperator => "neq_operator",
                ASTSubtractionOperatorNodeInputRightDiscriminatorType.NumberLiteral => "number_literal",
                ASTSubtractionOperatorNodeInputRightDiscriminatorType.OrOperator => "or_operator",
                ASTSubtractionOperatorNodeInputRightDiscriminatorType.StringLiteral => "string_literal",
                ASTSubtractionOperatorNodeInputRightDiscriminatorType.SubOperator => "sub_operator",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ASTSubtractionOperatorNodeInputRightDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "add_operator" => ASTSubtractionOperatorNodeInputRightDiscriminatorType.AddOperator,
                "and_operator" => ASTSubtractionOperatorNodeInputRightDiscriminatorType.AndOperator,
                "boolean_literal" => ASTSubtractionOperatorNodeInputRightDiscriminatorType.BooleanLiteral,
                "conditional_operator" => ASTSubtractionOperatorNodeInputRightDiscriminatorType.ConditionalOperator,
                "div_operator" => ASTSubtractionOperatorNodeInputRightDiscriminatorType.DivOperator,
                "dynamic_variable" => ASTSubtractionOperatorNodeInputRightDiscriminatorType.DynamicVariable,
                "eq_operator" => ASTSubtractionOperatorNodeInputRightDiscriminatorType.EqOperator,
                "gt_operator" => ASTSubtractionOperatorNodeInputRightDiscriminatorType.GtOperator,
                "gte_operator" => ASTSubtractionOperatorNodeInputRightDiscriminatorType.GteOperator,
                "llm" => ASTSubtractionOperatorNodeInputRightDiscriminatorType.Llm,
                "lt_operator" => ASTSubtractionOperatorNodeInputRightDiscriminatorType.LtOperator,
                "lte_operator" => ASTSubtractionOperatorNodeInputRightDiscriminatorType.LteOperator,
                "mul_operator" => ASTSubtractionOperatorNodeInputRightDiscriminatorType.MulOperator,
                "neq_operator" => ASTSubtractionOperatorNodeInputRightDiscriminatorType.NeqOperator,
                "number_literal" => ASTSubtractionOperatorNodeInputRightDiscriminatorType.NumberLiteral,
                "or_operator" => ASTSubtractionOperatorNodeInputRightDiscriminatorType.OrOperator,
                "string_literal" => ASTSubtractionOperatorNodeInputRightDiscriminatorType.StringLiteral,
                "sub_operator" => ASTSubtractionOperatorNodeInputRightDiscriminatorType.SubOperator,
                _ => null,
            };
        }
    }
}