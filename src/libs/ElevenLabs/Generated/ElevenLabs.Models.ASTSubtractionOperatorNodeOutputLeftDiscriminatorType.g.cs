
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public enum ASTSubtractionOperatorNodeOutputLeftDiscriminatorType
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
    public static class ASTSubtractionOperatorNodeOutputLeftDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ASTSubtractionOperatorNodeOutputLeftDiscriminatorType value)
        {
            return value switch
            {
                ASTSubtractionOperatorNodeOutputLeftDiscriminatorType.AddOperator => "add_operator",
                ASTSubtractionOperatorNodeOutputLeftDiscriminatorType.AndOperator => "and_operator",
                ASTSubtractionOperatorNodeOutputLeftDiscriminatorType.BooleanLiteral => "boolean_literal",
                ASTSubtractionOperatorNodeOutputLeftDiscriminatorType.ConditionalOperator => "conditional_operator",
                ASTSubtractionOperatorNodeOutputLeftDiscriminatorType.DivOperator => "div_operator",
                ASTSubtractionOperatorNodeOutputLeftDiscriminatorType.DynamicVariable => "dynamic_variable",
                ASTSubtractionOperatorNodeOutputLeftDiscriminatorType.EqOperator => "eq_operator",
                ASTSubtractionOperatorNodeOutputLeftDiscriminatorType.GtOperator => "gt_operator",
                ASTSubtractionOperatorNodeOutputLeftDiscriminatorType.GteOperator => "gte_operator",
                ASTSubtractionOperatorNodeOutputLeftDiscriminatorType.Llm => "llm",
                ASTSubtractionOperatorNodeOutputLeftDiscriminatorType.LtOperator => "lt_operator",
                ASTSubtractionOperatorNodeOutputLeftDiscriminatorType.LteOperator => "lte_operator",
                ASTSubtractionOperatorNodeOutputLeftDiscriminatorType.MulOperator => "mul_operator",
                ASTSubtractionOperatorNodeOutputLeftDiscriminatorType.NeqOperator => "neq_operator",
                ASTSubtractionOperatorNodeOutputLeftDiscriminatorType.NumberLiteral => "number_literal",
                ASTSubtractionOperatorNodeOutputLeftDiscriminatorType.OrOperator => "or_operator",
                ASTSubtractionOperatorNodeOutputLeftDiscriminatorType.StringLiteral => "string_literal",
                ASTSubtractionOperatorNodeOutputLeftDiscriminatorType.SubOperator => "sub_operator",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ASTSubtractionOperatorNodeOutputLeftDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "add_operator" => ASTSubtractionOperatorNodeOutputLeftDiscriminatorType.AddOperator,
                "and_operator" => ASTSubtractionOperatorNodeOutputLeftDiscriminatorType.AndOperator,
                "boolean_literal" => ASTSubtractionOperatorNodeOutputLeftDiscriminatorType.BooleanLiteral,
                "conditional_operator" => ASTSubtractionOperatorNodeOutputLeftDiscriminatorType.ConditionalOperator,
                "div_operator" => ASTSubtractionOperatorNodeOutputLeftDiscriminatorType.DivOperator,
                "dynamic_variable" => ASTSubtractionOperatorNodeOutputLeftDiscriminatorType.DynamicVariable,
                "eq_operator" => ASTSubtractionOperatorNodeOutputLeftDiscriminatorType.EqOperator,
                "gt_operator" => ASTSubtractionOperatorNodeOutputLeftDiscriminatorType.GtOperator,
                "gte_operator" => ASTSubtractionOperatorNodeOutputLeftDiscriminatorType.GteOperator,
                "llm" => ASTSubtractionOperatorNodeOutputLeftDiscriminatorType.Llm,
                "lt_operator" => ASTSubtractionOperatorNodeOutputLeftDiscriminatorType.LtOperator,
                "lte_operator" => ASTSubtractionOperatorNodeOutputLeftDiscriminatorType.LteOperator,
                "mul_operator" => ASTSubtractionOperatorNodeOutputLeftDiscriminatorType.MulOperator,
                "neq_operator" => ASTSubtractionOperatorNodeOutputLeftDiscriminatorType.NeqOperator,
                "number_literal" => ASTSubtractionOperatorNodeOutputLeftDiscriminatorType.NumberLiteral,
                "or_operator" => ASTSubtractionOperatorNodeOutputLeftDiscriminatorType.OrOperator,
                "string_literal" => ASTSubtractionOperatorNodeOutputLeftDiscriminatorType.StringLiteral,
                "sub_operator" => ASTSubtractionOperatorNodeOutputLeftDiscriminatorType.SubOperator,
                _ => null,
            };
        }
    }
}