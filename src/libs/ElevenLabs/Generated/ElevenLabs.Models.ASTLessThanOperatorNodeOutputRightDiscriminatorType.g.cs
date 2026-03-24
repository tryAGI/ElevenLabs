
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public enum ASTLessThanOperatorNodeOutputRightDiscriminatorType
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
    public static class ASTLessThanOperatorNodeOutputRightDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ASTLessThanOperatorNodeOutputRightDiscriminatorType value)
        {
            return value switch
            {
                ASTLessThanOperatorNodeOutputRightDiscriminatorType.AddOperator => "add_operator",
                ASTLessThanOperatorNodeOutputRightDiscriminatorType.AndOperator => "and_operator",
                ASTLessThanOperatorNodeOutputRightDiscriminatorType.BooleanLiteral => "boolean_literal",
                ASTLessThanOperatorNodeOutputRightDiscriminatorType.ConditionalOperator => "conditional_operator",
                ASTLessThanOperatorNodeOutputRightDiscriminatorType.DivOperator => "div_operator",
                ASTLessThanOperatorNodeOutputRightDiscriminatorType.DynamicVariable => "dynamic_variable",
                ASTLessThanOperatorNodeOutputRightDiscriminatorType.EqOperator => "eq_operator",
                ASTLessThanOperatorNodeOutputRightDiscriminatorType.GtOperator => "gt_operator",
                ASTLessThanOperatorNodeOutputRightDiscriminatorType.GteOperator => "gte_operator",
                ASTLessThanOperatorNodeOutputRightDiscriminatorType.Llm => "llm",
                ASTLessThanOperatorNodeOutputRightDiscriminatorType.LtOperator => "lt_operator",
                ASTLessThanOperatorNodeOutputRightDiscriminatorType.LteOperator => "lte_operator",
                ASTLessThanOperatorNodeOutputRightDiscriminatorType.MulOperator => "mul_operator",
                ASTLessThanOperatorNodeOutputRightDiscriminatorType.NeqOperator => "neq_operator",
                ASTLessThanOperatorNodeOutputRightDiscriminatorType.NumberLiteral => "number_literal",
                ASTLessThanOperatorNodeOutputRightDiscriminatorType.OrOperator => "or_operator",
                ASTLessThanOperatorNodeOutputRightDiscriminatorType.StringLiteral => "string_literal",
                ASTLessThanOperatorNodeOutputRightDiscriminatorType.SubOperator => "sub_operator",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ASTLessThanOperatorNodeOutputRightDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "add_operator" => ASTLessThanOperatorNodeOutputRightDiscriminatorType.AddOperator,
                "and_operator" => ASTLessThanOperatorNodeOutputRightDiscriminatorType.AndOperator,
                "boolean_literal" => ASTLessThanOperatorNodeOutputRightDiscriminatorType.BooleanLiteral,
                "conditional_operator" => ASTLessThanOperatorNodeOutputRightDiscriminatorType.ConditionalOperator,
                "div_operator" => ASTLessThanOperatorNodeOutputRightDiscriminatorType.DivOperator,
                "dynamic_variable" => ASTLessThanOperatorNodeOutputRightDiscriminatorType.DynamicVariable,
                "eq_operator" => ASTLessThanOperatorNodeOutputRightDiscriminatorType.EqOperator,
                "gt_operator" => ASTLessThanOperatorNodeOutputRightDiscriminatorType.GtOperator,
                "gte_operator" => ASTLessThanOperatorNodeOutputRightDiscriminatorType.GteOperator,
                "llm" => ASTLessThanOperatorNodeOutputRightDiscriminatorType.Llm,
                "lt_operator" => ASTLessThanOperatorNodeOutputRightDiscriminatorType.LtOperator,
                "lte_operator" => ASTLessThanOperatorNodeOutputRightDiscriminatorType.LteOperator,
                "mul_operator" => ASTLessThanOperatorNodeOutputRightDiscriminatorType.MulOperator,
                "neq_operator" => ASTLessThanOperatorNodeOutputRightDiscriminatorType.NeqOperator,
                "number_literal" => ASTLessThanOperatorNodeOutputRightDiscriminatorType.NumberLiteral,
                "or_operator" => ASTLessThanOperatorNodeOutputRightDiscriminatorType.OrOperator,
                "string_literal" => ASTLessThanOperatorNodeOutputRightDiscriminatorType.StringLiteral,
                "sub_operator" => ASTLessThanOperatorNodeOutputRightDiscriminatorType.SubOperator,
                _ => null,
            };
        }
    }
}