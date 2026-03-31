
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public enum ASTNodeInputDiscriminatorType
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
    public static class ASTNodeInputDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ASTNodeInputDiscriminatorType value)
        {
            return value switch
            {
                ASTNodeInputDiscriminatorType.AddOperator => "add_operator",
                ASTNodeInputDiscriminatorType.AndOperator => "and_operator",
                ASTNodeInputDiscriminatorType.BooleanLiteral => "boolean_literal",
                ASTNodeInputDiscriminatorType.ConditionalOperator => "conditional_operator",
                ASTNodeInputDiscriminatorType.DivOperator => "div_operator",
                ASTNodeInputDiscriminatorType.DynamicVariable => "dynamic_variable",
                ASTNodeInputDiscriminatorType.EqOperator => "eq_operator",
                ASTNodeInputDiscriminatorType.GtOperator => "gt_operator",
                ASTNodeInputDiscriminatorType.GteOperator => "gte_operator",
                ASTNodeInputDiscriminatorType.Llm => "llm",
                ASTNodeInputDiscriminatorType.LtOperator => "lt_operator",
                ASTNodeInputDiscriminatorType.LteOperator => "lte_operator",
                ASTNodeInputDiscriminatorType.MulOperator => "mul_operator",
                ASTNodeInputDiscriminatorType.NeqOperator => "neq_operator",
                ASTNodeInputDiscriminatorType.NumberLiteral => "number_literal",
                ASTNodeInputDiscriminatorType.OrOperator => "or_operator",
                ASTNodeInputDiscriminatorType.StringLiteral => "string_literal",
                ASTNodeInputDiscriminatorType.SubOperator => "sub_operator",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ASTNodeInputDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "add_operator" => ASTNodeInputDiscriminatorType.AddOperator,
                "and_operator" => ASTNodeInputDiscriminatorType.AndOperator,
                "boolean_literal" => ASTNodeInputDiscriminatorType.BooleanLiteral,
                "conditional_operator" => ASTNodeInputDiscriminatorType.ConditionalOperator,
                "div_operator" => ASTNodeInputDiscriminatorType.DivOperator,
                "dynamic_variable" => ASTNodeInputDiscriminatorType.DynamicVariable,
                "eq_operator" => ASTNodeInputDiscriminatorType.EqOperator,
                "gt_operator" => ASTNodeInputDiscriminatorType.GtOperator,
                "gte_operator" => ASTNodeInputDiscriminatorType.GteOperator,
                "llm" => ASTNodeInputDiscriminatorType.Llm,
                "lt_operator" => ASTNodeInputDiscriminatorType.LtOperator,
                "lte_operator" => ASTNodeInputDiscriminatorType.LteOperator,
                "mul_operator" => ASTNodeInputDiscriminatorType.MulOperator,
                "neq_operator" => ASTNodeInputDiscriminatorType.NeqOperator,
                "number_literal" => ASTNodeInputDiscriminatorType.NumberLiteral,
                "or_operator" => ASTNodeInputDiscriminatorType.OrOperator,
                "string_literal" => ASTNodeInputDiscriminatorType.StringLiteral,
                "sub_operator" => ASTNodeInputDiscriminatorType.SubOperator,
                _ => null,
            };
        }
    }
}