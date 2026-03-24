
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public enum ASTOrOperatorNodeInputChildrenItemDiscriminatorType
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
    public static class ASTOrOperatorNodeInputChildrenItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ASTOrOperatorNodeInputChildrenItemDiscriminatorType value)
        {
            return value switch
            {
                ASTOrOperatorNodeInputChildrenItemDiscriminatorType.AddOperator => "add_operator",
                ASTOrOperatorNodeInputChildrenItemDiscriminatorType.AndOperator => "and_operator",
                ASTOrOperatorNodeInputChildrenItemDiscriminatorType.BooleanLiteral => "boolean_literal",
                ASTOrOperatorNodeInputChildrenItemDiscriminatorType.ConditionalOperator => "conditional_operator",
                ASTOrOperatorNodeInputChildrenItemDiscriminatorType.DivOperator => "div_operator",
                ASTOrOperatorNodeInputChildrenItemDiscriminatorType.DynamicVariable => "dynamic_variable",
                ASTOrOperatorNodeInputChildrenItemDiscriminatorType.EqOperator => "eq_operator",
                ASTOrOperatorNodeInputChildrenItemDiscriminatorType.GtOperator => "gt_operator",
                ASTOrOperatorNodeInputChildrenItemDiscriminatorType.GteOperator => "gte_operator",
                ASTOrOperatorNodeInputChildrenItemDiscriminatorType.Llm => "llm",
                ASTOrOperatorNodeInputChildrenItemDiscriminatorType.LtOperator => "lt_operator",
                ASTOrOperatorNodeInputChildrenItemDiscriminatorType.LteOperator => "lte_operator",
                ASTOrOperatorNodeInputChildrenItemDiscriminatorType.MulOperator => "mul_operator",
                ASTOrOperatorNodeInputChildrenItemDiscriminatorType.NeqOperator => "neq_operator",
                ASTOrOperatorNodeInputChildrenItemDiscriminatorType.NumberLiteral => "number_literal",
                ASTOrOperatorNodeInputChildrenItemDiscriminatorType.OrOperator => "or_operator",
                ASTOrOperatorNodeInputChildrenItemDiscriminatorType.StringLiteral => "string_literal",
                ASTOrOperatorNodeInputChildrenItemDiscriminatorType.SubOperator => "sub_operator",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ASTOrOperatorNodeInputChildrenItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "add_operator" => ASTOrOperatorNodeInputChildrenItemDiscriminatorType.AddOperator,
                "and_operator" => ASTOrOperatorNodeInputChildrenItemDiscriminatorType.AndOperator,
                "boolean_literal" => ASTOrOperatorNodeInputChildrenItemDiscriminatorType.BooleanLiteral,
                "conditional_operator" => ASTOrOperatorNodeInputChildrenItemDiscriminatorType.ConditionalOperator,
                "div_operator" => ASTOrOperatorNodeInputChildrenItemDiscriminatorType.DivOperator,
                "dynamic_variable" => ASTOrOperatorNodeInputChildrenItemDiscriminatorType.DynamicVariable,
                "eq_operator" => ASTOrOperatorNodeInputChildrenItemDiscriminatorType.EqOperator,
                "gt_operator" => ASTOrOperatorNodeInputChildrenItemDiscriminatorType.GtOperator,
                "gte_operator" => ASTOrOperatorNodeInputChildrenItemDiscriminatorType.GteOperator,
                "llm" => ASTOrOperatorNodeInputChildrenItemDiscriminatorType.Llm,
                "lt_operator" => ASTOrOperatorNodeInputChildrenItemDiscriminatorType.LtOperator,
                "lte_operator" => ASTOrOperatorNodeInputChildrenItemDiscriminatorType.LteOperator,
                "mul_operator" => ASTOrOperatorNodeInputChildrenItemDiscriminatorType.MulOperator,
                "neq_operator" => ASTOrOperatorNodeInputChildrenItemDiscriminatorType.NeqOperator,
                "number_literal" => ASTOrOperatorNodeInputChildrenItemDiscriminatorType.NumberLiteral,
                "or_operator" => ASTOrOperatorNodeInputChildrenItemDiscriminatorType.OrOperator,
                "string_literal" => ASTOrOperatorNodeInputChildrenItemDiscriminatorType.StringLiteral,
                "sub_operator" => ASTOrOperatorNodeInputChildrenItemDiscriminatorType.SubOperator,
                _ => null,
            };
        }
    }
}