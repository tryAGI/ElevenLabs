
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public enum ASTAndOperatorNodeInputChildrenItemDiscriminatorType
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
    public static class ASTAndOperatorNodeInputChildrenItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ASTAndOperatorNodeInputChildrenItemDiscriminatorType value)
        {
            return value switch
            {
                ASTAndOperatorNodeInputChildrenItemDiscriminatorType.AddOperator => "add_operator",
                ASTAndOperatorNodeInputChildrenItemDiscriminatorType.AndOperator => "and_operator",
                ASTAndOperatorNodeInputChildrenItemDiscriminatorType.BooleanLiteral => "boolean_literal",
                ASTAndOperatorNodeInputChildrenItemDiscriminatorType.ConditionalOperator => "conditional_operator",
                ASTAndOperatorNodeInputChildrenItemDiscriminatorType.DivOperator => "div_operator",
                ASTAndOperatorNodeInputChildrenItemDiscriminatorType.DynamicVariable => "dynamic_variable",
                ASTAndOperatorNodeInputChildrenItemDiscriminatorType.EqOperator => "eq_operator",
                ASTAndOperatorNodeInputChildrenItemDiscriminatorType.GtOperator => "gt_operator",
                ASTAndOperatorNodeInputChildrenItemDiscriminatorType.GteOperator => "gte_operator",
                ASTAndOperatorNodeInputChildrenItemDiscriminatorType.Llm => "llm",
                ASTAndOperatorNodeInputChildrenItemDiscriminatorType.LtOperator => "lt_operator",
                ASTAndOperatorNodeInputChildrenItemDiscriminatorType.LteOperator => "lte_operator",
                ASTAndOperatorNodeInputChildrenItemDiscriminatorType.MulOperator => "mul_operator",
                ASTAndOperatorNodeInputChildrenItemDiscriminatorType.NeqOperator => "neq_operator",
                ASTAndOperatorNodeInputChildrenItemDiscriminatorType.NumberLiteral => "number_literal",
                ASTAndOperatorNodeInputChildrenItemDiscriminatorType.OrOperator => "or_operator",
                ASTAndOperatorNodeInputChildrenItemDiscriminatorType.StringLiteral => "string_literal",
                ASTAndOperatorNodeInputChildrenItemDiscriminatorType.SubOperator => "sub_operator",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ASTAndOperatorNodeInputChildrenItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "add_operator" => ASTAndOperatorNodeInputChildrenItemDiscriminatorType.AddOperator,
                "and_operator" => ASTAndOperatorNodeInputChildrenItemDiscriminatorType.AndOperator,
                "boolean_literal" => ASTAndOperatorNodeInputChildrenItemDiscriminatorType.BooleanLiteral,
                "conditional_operator" => ASTAndOperatorNodeInputChildrenItemDiscriminatorType.ConditionalOperator,
                "div_operator" => ASTAndOperatorNodeInputChildrenItemDiscriminatorType.DivOperator,
                "dynamic_variable" => ASTAndOperatorNodeInputChildrenItemDiscriminatorType.DynamicVariable,
                "eq_operator" => ASTAndOperatorNodeInputChildrenItemDiscriminatorType.EqOperator,
                "gt_operator" => ASTAndOperatorNodeInputChildrenItemDiscriminatorType.GtOperator,
                "gte_operator" => ASTAndOperatorNodeInputChildrenItemDiscriminatorType.GteOperator,
                "llm" => ASTAndOperatorNodeInputChildrenItemDiscriminatorType.Llm,
                "lt_operator" => ASTAndOperatorNodeInputChildrenItemDiscriminatorType.LtOperator,
                "lte_operator" => ASTAndOperatorNodeInputChildrenItemDiscriminatorType.LteOperator,
                "mul_operator" => ASTAndOperatorNodeInputChildrenItemDiscriminatorType.MulOperator,
                "neq_operator" => ASTAndOperatorNodeInputChildrenItemDiscriminatorType.NeqOperator,
                "number_literal" => ASTAndOperatorNodeInputChildrenItemDiscriminatorType.NumberLiteral,
                "or_operator" => ASTAndOperatorNodeInputChildrenItemDiscriminatorType.OrOperator,
                "string_literal" => ASTAndOperatorNodeInputChildrenItemDiscriminatorType.StringLiteral,
                "sub_operator" => ASTAndOperatorNodeInputChildrenItemDiscriminatorType.SubOperator,
                _ => null,
            };
        }
    }
}