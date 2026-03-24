
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public enum ASTSubtractionOperatorNodeOutputRightDiscriminatorType
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
    public static class ASTSubtractionOperatorNodeOutputRightDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ASTSubtractionOperatorNodeOutputRightDiscriminatorType value)
        {
            return value switch
            {
                ASTSubtractionOperatorNodeOutputRightDiscriminatorType.AddOperator => "add_operator",
                ASTSubtractionOperatorNodeOutputRightDiscriminatorType.AndOperator => "and_operator",
                ASTSubtractionOperatorNodeOutputRightDiscriminatorType.BooleanLiteral => "boolean_literal",
                ASTSubtractionOperatorNodeOutputRightDiscriminatorType.ConditionalOperator => "conditional_operator",
                ASTSubtractionOperatorNodeOutputRightDiscriminatorType.DivOperator => "div_operator",
                ASTSubtractionOperatorNodeOutputRightDiscriminatorType.DynamicVariable => "dynamic_variable",
                ASTSubtractionOperatorNodeOutputRightDiscriminatorType.EqOperator => "eq_operator",
                ASTSubtractionOperatorNodeOutputRightDiscriminatorType.GtOperator => "gt_operator",
                ASTSubtractionOperatorNodeOutputRightDiscriminatorType.GteOperator => "gte_operator",
                ASTSubtractionOperatorNodeOutputRightDiscriminatorType.Llm => "llm",
                ASTSubtractionOperatorNodeOutputRightDiscriminatorType.LtOperator => "lt_operator",
                ASTSubtractionOperatorNodeOutputRightDiscriminatorType.LteOperator => "lte_operator",
                ASTSubtractionOperatorNodeOutputRightDiscriminatorType.MulOperator => "mul_operator",
                ASTSubtractionOperatorNodeOutputRightDiscriminatorType.NeqOperator => "neq_operator",
                ASTSubtractionOperatorNodeOutputRightDiscriminatorType.NumberLiteral => "number_literal",
                ASTSubtractionOperatorNodeOutputRightDiscriminatorType.OrOperator => "or_operator",
                ASTSubtractionOperatorNodeOutputRightDiscriminatorType.StringLiteral => "string_literal",
                ASTSubtractionOperatorNodeOutputRightDiscriminatorType.SubOperator => "sub_operator",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ASTSubtractionOperatorNodeOutputRightDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "add_operator" => ASTSubtractionOperatorNodeOutputRightDiscriminatorType.AddOperator,
                "and_operator" => ASTSubtractionOperatorNodeOutputRightDiscriminatorType.AndOperator,
                "boolean_literal" => ASTSubtractionOperatorNodeOutputRightDiscriminatorType.BooleanLiteral,
                "conditional_operator" => ASTSubtractionOperatorNodeOutputRightDiscriminatorType.ConditionalOperator,
                "div_operator" => ASTSubtractionOperatorNodeOutputRightDiscriminatorType.DivOperator,
                "dynamic_variable" => ASTSubtractionOperatorNodeOutputRightDiscriminatorType.DynamicVariable,
                "eq_operator" => ASTSubtractionOperatorNodeOutputRightDiscriminatorType.EqOperator,
                "gt_operator" => ASTSubtractionOperatorNodeOutputRightDiscriminatorType.GtOperator,
                "gte_operator" => ASTSubtractionOperatorNodeOutputRightDiscriminatorType.GteOperator,
                "llm" => ASTSubtractionOperatorNodeOutputRightDiscriminatorType.Llm,
                "lt_operator" => ASTSubtractionOperatorNodeOutputRightDiscriminatorType.LtOperator,
                "lte_operator" => ASTSubtractionOperatorNodeOutputRightDiscriminatorType.LteOperator,
                "mul_operator" => ASTSubtractionOperatorNodeOutputRightDiscriminatorType.MulOperator,
                "neq_operator" => ASTSubtractionOperatorNodeOutputRightDiscriminatorType.NeqOperator,
                "number_literal" => ASTSubtractionOperatorNodeOutputRightDiscriminatorType.NumberLiteral,
                "or_operator" => ASTSubtractionOperatorNodeOutputRightDiscriminatorType.OrOperator,
                "string_literal" => ASTSubtractionOperatorNodeOutputRightDiscriminatorType.StringLiteral,
                "sub_operator" => ASTSubtractionOperatorNodeOutputRightDiscriminatorType.SubOperator,
                _ => null,
            };
        }
    }
}