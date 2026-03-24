
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public enum ASTAndOperatorNodeOutputChildrenItemDiscriminatorType
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
    public static class ASTAndOperatorNodeOutputChildrenItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ASTAndOperatorNodeOutputChildrenItemDiscriminatorType value)
        {
            return value switch
            {
                ASTAndOperatorNodeOutputChildrenItemDiscriminatorType.AddOperator => "add_operator",
                ASTAndOperatorNodeOutputChildrenItemDiscriminatorType.AndOperator => "and_operator",
                ASTAndOperatorNodeOutputChildrenItemDiscriminatorType.BooleanLiteral => "boolean_literal",
                ASTAndOperatorNodeOutputChildrenItemDiscriminatorType.ConditionalOperator => "conditional_operator",
                ASTAndOperatorNodeOutputChildrenItemDiscriminatorType.DivOperator => "div_operator",
                ASTAndOperatorNodeOutputChildrenItemDiscriminatorType.DynamicVariable => "dynamic_variable",
                ASTAndOperatorNodeOutputChildrenItemDiscriminatorType.EqOperator => "eq_operator",
                ASTAndOperatorNodeOutputChildrenItemDiscriminatorType.GtOperator => "gt_operator",
                ASTAndOperatorNodeOutputChildrenItemDiscriminatorType.GteOperator => "gte_operator",
                ASTAndOperatorNodeOutputChildrenItemDiscriminatorType.Llm => "llm",
                ASTAndOperatorNodeOutputChildrenItemDiscriminatorType.LtOperator => "lt_operator",
                ASTAndOperatorNodeOutputChildrenItemDiscriminatorType.LteOperator => "lte_operator",
                ASTAndOperatorNodeOutputChildrenItemDiscriminatorType.MulOperator => "mul_operator",
                ASTAndOperatorNodeOutputChildrenItemDiscriminatorType.NeqOperator => "neq_operator",
                ASTAndOperatorNodeOutputChildrenItemDiscriminatorType.NumberLiteral => "number_literal",
                ASTAndOperatorNodeOutputChildrenItemDiscriminatorType.OrOperator => "or_operator",
                ASTAndOperatorNodeOutputChildrenItemDiscriminatorType.StringLiteral => "string_literal",
                ASTAndOperatorNodeOutputChildrenItemDiscriminatorType.SubOperator => "sub_operator",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ASTAndOperatorNodeOutputChildrenItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "add_operator" => ASTAndOperatorNodeOutputChildrenItemDiscriminatorType.AddOperator,
                "and_operator" => ASTAndOperatorNodeOutputChildrenItemDiscriminatorType.AndOperator,
                "boolean_literal" => ASTAndOperatorNodeOutputChildrenItemDiscriminatorType.BooleanLiteral,
                "conditional_operator" => ASTAndOperatorNodeOutputChildrenItemDiscriminatorType.ConditionalOperator,
                "div_operator" => ASTAndOperatorNodeOutputChildrenItemDiscriminatorType.DivOperator,
                "dynamic_variable" => ASTAndOperatorNodeOutputChildrenItemDiscriminatorType.DynamicVariable,
                "eq_operator" => ASTAndOperatorNodeOutputChildrenItemDiscriminatorType.EqOperator,
                "gt_operator" => ASTAndOperatorNodeOutputChildrenItemDiscriminatorType.GtOperator,
                "gte_operator" => ASTAndOperatorNodeOutputChildrenItemDiscriminatorType.GteOperator,
                "llm" => ASTAndOperatorNodeOutputChildrenItemDiscriminatorType.Llm,
                "lt_operator" => ASTAndOperatorNodeOutputChildrenItemDiscriminatorType.LtOperator,
                "lte_operator" => ASTAndOperatorNodeOutputChildrenItemDiscriminatorType.LteOperator,
                "mul_operator" => ASTAndOperatorNodeOutputChildrenItemDiscriminatorType.MulOperator,
                "neq_operator" => ASTAndOperatorNodeOutputChildrenItemDiscriminatorType.NeqOperator,
                "number_literal" => ASTAndOperatorNodeOutputChildrenItemDiscriminatorType.NumberLiteral,
                "or_operator" => ASTAndOperatorNodeOutputChildrenItemDiscriminatorType.OrOperator,
                "string_literal" => ASTAndOperatorNodeOutputChildrenItemDiscriminatorType.StringLiteral,
                "sub_operator" => ASTAndOperatorNodeOutputChildrenItemDiscriminatorType.SubOperator,
                _ => null,
            };
        }
    }
}