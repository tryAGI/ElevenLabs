
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public enum ASTNotEqualsOperatorNodeOutputRightDiscriminatorType
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
    public static class ASTNotEqualsOperatorNodeOutputRightDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ASTNotEqualsOperatorNodeOutputRightDiscriminatorType value)
        {
            return value switch
            {
                ASTNotEqualsOperatorNodeOutputRightDiscriminatorType.AddOperator => "add_operator",
                ASTNotEqualsOperatorNodeOutputRightDiscriminatorType.AndOperator => "and_operator",
                ASTNotEqualsOperatorNodeOutputRightDiscriminatorType.BooleanLiteral => "boolean_literal",
                ASTNotEqualsOperatorNodeOutputRightDiscriminatorType.ConditionalOperator => "conditional_operator",
                ASTNotEqualsOperatorNodeOutputRightDiscriminatorType.DivOperator => "div_operator",
                ASTNotEqualsOperatorNodeOutputRightDiscriminatorType.DynamicVariable => "dynamic_variable",
                ASTNotEqualsOperatorNodeOutputRightDiscriminatorType.EqOperator => "eq_operator",
                ASTNotEqualsOperatorNodeOutputRightDiscriminatorType.GtOperator => "gt_operator",
                ASTNotEqualsOperatorNodeOutputRightDiscriminatorType.GteOperator => "gte_operator",
                ASTNotEqualsOperatorNodeOutputRightDiscriminatorType.Llm => "llm",
                ASTNotEqualsOperatorNodeOutputRightDiscriminatorType.LtOperator => "lt_operator",
                ASTNotEqualsOperatorNodeOutputRightDiscriminatorType.LteOperator => "lte_operator",
                ASTNotEqualsOperatorNodeOutputRightDiscriminatorType.MulOperator => "mul_operator",
                ASTNotEqualsOperatorNodeOutputRightDiscriminatorType.NeqOperator => "neq_operator",
                ASTNotEqualsOperatorNodeOutputRightDiscriminatorType.NumberLiteral => "number_literal",
                ASTNotEqualsOperatorNodeOutputRightDiscriminatorType.OrOperator => "or_operator",
                ASTNotEqualsOperatorNodeOutputRightDiscriminatorType.StringLiteral => "string_literal",
                ASTNotEqualsOperatorNodeOutputRightDiscriminatorType.SubOperator => "sub_operator",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ASTNotEqualsOperatorNodeOutputRightDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "add_operator" => ASTNotEqualsOperatorNodeOutputRightDiscriminatorType.AddOperator,
                "and_operator" => ASTNotEqualsOperatorNodeOutputRightDiscriminatorType.AndOperator,
                "boolean_literal" => ASTNotEqualsOperatorNodeOutputRightDiscriminatorType.BooleanLiteral,
                "conditional_operator" => ASTNotEqualsOperatorNodeOutputRightDiscriminatorType.ConditionalOperator,
                "div_operator" => ASTNotEqualsOperatorNodeOutputRightDiscriminatorType.DivOperator,
                "dynamic_variable" => ASTNotEqualsOperatorNodeOutputRightDiscriminatorType.DynamicVariable,
                "eq_operator" => ASTNotEqualsOperatorNodeOutputRightDiscriminatorType.EqOperator,
                "gt_operator" => ASTNotEqualsOperatorNodeOutputRightDiscriminatorType.GtOperator,
                "gte_operator" => ASTNotEqualsOperatorNodeOutputRightDiscriminatorType.GteOperator,
                "llm" => ASTNotEqualsOperatorNodeOutputRightDiscriminatorType.Llm,
                "lt_operator" => ASTNotEqualsOperatorNodeOutputRightDiscriminatorType.LtOperator,
                "lte_operator" => ASTNotEqualsOperatorNodeOutputRightDiscriminatorType.LteOperator,
                "mul_operator" => ASTNotEqualsOperatorNodeOutputRightDiscriminatorType.MulOperator,
                "neq_operator" => ASTNotEqualsOperatorNodeOutputRightDiscriminatorType.NeqOperator,
                "number_literal" => ASTNotEqualsOperatorNodeOutputRightDiscriminatorType.NumberLiteral,
                "or_operator" => ASTNotEqualsOperatorNodeOutputRightDiscriminatorType.OrOperator,
                "string_literal" => ASTNotEqualsOperatorNodeOutputRightDiscriminatorType.StringLiteral,
                "sub_operator" => ASTNotEqualsOperatorNodeOutputRightDiscriminatorType.SubOperator,
                _ => null,
            };
        }
    }
}