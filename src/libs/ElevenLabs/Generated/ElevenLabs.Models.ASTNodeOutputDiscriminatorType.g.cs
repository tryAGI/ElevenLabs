
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public enum ASTNodeOutputDiscriminatorType
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
    public static class ASTNodeOutputDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ASTNodeOutputDiscriminatorType value)
        {
            return value switch
            {
                ASTNodeOutputDiscriminatorType.AddOperator => "add_operator",
                ASTNodeOutputDiscriminatorType.AndOperator => "and_operator",
                ASTNodeOutputDiscriminatorType.BooleanLiteral => "boolean_literal",
                ASTNodeOutputDiscriminatorType.ConditionalOperator => "conditional_operator",
                ASTNodeOutputDiscriminatorType.DivOperator => "div_operator",
                ASTNodeOutputDiscriminatorType.DynamicVariable => "dynamic_variable",
                ASTNodeOutputDiscriminatorType.EqOperator => "eq_operator",
                ASTNodeOutputDiscriminatorType.GtOperator => "gt_operator",
                ASTNodeOutputDiscriminatorType.GteOperator => "gte_operator",
                ASTNodeOutputDiscriminatorType.Llm => "llm",
                ASTNodeOutputDiscriminatorType.LtOperator => "lt_operator",
                ASTNodeOutputDiscriminatorType.LteOperator => "lte_operator",
                ASTNodeOutputDiscriminatorType.MulOperator => "mul_operator",
                ASTNodeOutputDiscriminatorType.NeqOperator => "neq_operator",
                ASTNodeOutputDiscriminatorType.NumberLiteral => "number_literal",
                ASTNodeOutputDiscriminatorType.OrOperator => "or_operator",
                ASTNodeOutputDiscriminatorType.StringLiteral => "string_literal",
                ASTNodeOutputDiscriminatorType.SubOperator => "sub_operator",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ASTNodeOutputDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "add_operator" => ASTNodeOutputDiscriminatorType.AddOperator,
                "and_operator" => ASTNodeOutputDiscriminatorType.AndOperator,
                "boolean_literal" => ASTNodeOutputDiscriminatorType.BooleanLiteral,
                "conditional_operator" => ASTNodeOutputDiscriminatorType.ConditionalOperator,
                "div_operator" => ASTNodeOutputDiscriminatorType.DivOperator,
                "dynamic_variable" => ASTNodeOutputDiscriminatorType.DynamicVariable,
                "eq_operator" => ASTNodeOutputDiscriminatorType.EqOperator,
                "gt_operator" => ASTNodeOutputDiscriminatorType.GtOperator,
                "gte_operator" => ASTNodeOutputDiscriminatorType.GteOperator,
                "llm" => ASTNodeOutputDiscriminatorType.Llm,
                "lt_operator" => ASTNodeOutputDiscriminatorType.LtOperator,
                "lte_operator" => ASTNodeOutputDiscriminatorType.LteOperator,
                "mul_operator" => ASTNodeOutputDiscriminatorType.MulOperator,
                "neq_operator" => ASTNodeOutputDiscriminatorType.NeqOperator,
                "number_literal" => ASTNodeOutputDiscriminatorType.NumberLiteral,
                "or_operator" => ASTNodeOutputDiscriminatorType.OrOperator,
                "string_literal" => ASTNodeOutputDiscriminatorType.StringLiteral,
                "sub_operator" => ASTNodeOutputDiscriminatorType.SubOperator,
                _ => null,
            };
        }
    }
}