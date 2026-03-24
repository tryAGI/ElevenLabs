
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public enum ASTAdditionOperatorNodeOutputRightDiscriminatorType
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
    public static class ASTAdditionOperatorNodeOutputRightDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ASTAdditionOperatorNodeOutputRightDiscriminatorType value)
        {
            return value switch
            {
                ASTAdditionOperatorNodeOutputRightDiscriminatorType.AddOperator => "add_operator",
                ASTAdditionOperatorNodeOutputRightDiscriminatorType.AndOperator => "and_operator",
                ASTAdditionOperatorNodeOutputRightDiscriminatorType.BooleanLiteral => "boolean_literal",
                ASTAdditionOperatorNodeOutputRightDiscriminatorType.ConditionalOperator => "conditional_operator",
                ASTAdditionOperatorNodeOutputRightDiscriminatorType.DivOperator => "div_operator",
                ASTAdditionOperatorNodeOutputRightDiscriminatorType.DynamicVariable => "dynamic_variable",
                ASTAdditionOperatorNodeOutputRightDiscriminatorType.EqOperator => "eq_operator",
                ASTAdditionOperatorNodeOutputRightDiscriminatorType.GtOperator => "gt_operator",
                ASTAdditionOperatorNodeOutputRightDiscriminatorType.GteOperator => "gte_operator",
                ASTAdditionOperatorNodeOutputRightDiscriminatorType.Llm => "llm",
                ASTAdditionOperatorNodeOutputRightDiscriminatorType.LtOperator => "lt_operator",
                ASTAdditionOperatorNodeOutputRightDiscriminatorType.LteOperator => "lte_operator",
                ASTAdditionOperatorNodeOutputRightDiscriminatorType.MulOperator => "mul_operator",
                ASTAdditionOperatorNodeOutputRightDiscriminatorType.NeqOperator => "neq_operator",
                ASTAdditionOperatorNodeOutputRightDiscriminatorType.NumberLiteral => "number_literal",
                ASTAdditionOperatorNodeOutputRightDiscriminatorType.OrOperator => "or_operator",
                ASTAdditionOperatorNodeOutputRightDiscriminatorType.StringLiteral => "string_literal",
                ASTAdditionOperatorNodeOutputRightDiscriminatorType.SubOperator => "sub_operator",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ASTAdditionOperatorNodeOutputRightDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "add_operator" => ASTAdditionOperatorNodeOutputRightDiscriminatorType.AddOperator,
                "and_operator" => ASTAdditionOperatorNodeOutputRightDiscriminatorType.AndOperator,
                "boolean_literal" => ASTAdditionOperatorNodeOutputRightDiscriminatorType.BooleanLiteral,
                "conditional_operator" => ASTAdditionOperatorNodeOutputRightDiscriminatorType.ConditionalOperator,
                "div_operator" => ASTAdditionOperatorNodeOutputRightDiscriminatorType.DivOperator,
                "dynamic_variable" => ASTAdditionOperatorNodeOutputRightDiscriminatorType.DynamicVariable,
                "eq_operator" => ASTAdditionOperatorNodeOutputRightDiscriminatorType.EqOperator,
                "gt_operator" => ASTAdditionOperatorNodeOutputRightDiscriminatorType.GtOperator,
                "gte_operator" => ASTAdditionOperatorNodeOutputRightDiscriminatorType.GteOperator,
                "llm" => ASTAdditionOperatorNodeOutputRightDiscriminatorType.Llm,
                "lt_operator" => ASTAdditionOperatorNodeOutputRightDiscriminatorType.LtOperator,
                "lte_operator" => ASTAdditionOperatorNodeOutputRightDiscriminatorType.LteOperator,
                "mul_operator" => ASTAdditionOperatorNodeOutputRightDiscriminatorType.MulOperator,
                "neq_operator" => ASTAdditionOperatorNodeOutputRightDiscriminatorType.NeqOperator,
                "number_literal" => ASTAdditionOperatorNodeOutputRightDiscriminatorType.NumberLiteral,
                "or_operator" => ASTAdditionOperatorNodeOutputRightDiscriminatorType.OrOperator,
                "string_literal" => ASTAdditionOperatorNodeOutputRightDiscriminatorType.StringLiteral,
                "sub_operator" => ASTAdditionOperatorNodeOutputRightDiscriminatorType.SubOperator,
                _ => null,
            };
        }
    }
}