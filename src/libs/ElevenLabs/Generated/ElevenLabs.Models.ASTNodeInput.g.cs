#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ASTNodeInput : global::System.IEquatable<ASTNodeInput>
    {
        /// <summary>
        /// String literal.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.ASTStringNodeInput? StringLiteral { get; init; }
#else
        public global::ElevenLabs.ASTStringNodeInput? StringLiteral { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StringLiteral))]
#endif
        public bool IsStringLiteral => StringLiteral != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickStringLiteral(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.ASTStringNodeInput? value)
        {
            value = StringLiteral;
            return IsStringLiteral;
        }

        /// <summary>
        /// Number literal.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.ASTNumberNodeInput? NumberLiteral { get; init; }
#else
        public global::ElevenLabs.ASTNumberNodeInput? NumberLiteral { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(NumberLiteral))]
#endif
        public bool IsNumberLiteral => NumberLiteral != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickNumberLiteral(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.ASTNumberNodeInput? value)
        {
            value = NumberLiteral;
            return IsNumberLiteral;
        }

        /// <summary>
        /// Boolean literal.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.ASTBooleanNodeInput? BooleanLiteral { get; init; }
#else
        public global::ElevenLabs.ASTBooleanNodeInput? BooleanLiteral { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BooleanLiteral))]
#endif
        public bool IsBooleanLiteral => BooleanLiteral != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickBooleanLiteral(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.ASTBooleanNodeInput? value)
        {
            value = BooleanLiteral;
            return IsBooleanLiteral;
        }

        /// <summary>
        /// Null literal.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.ASTNullNodeInput? NullLiteral { get; init; }
#else
        public global::ElevenLabs.ASTNullNodeInput? NullLiteral { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(NullLiteral))]
#endif
        public bool IsNullLiteral => NullLiteral != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickNullLiteral(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.ASTNullNodeInput? value)
        {
            value = NullLiteral;
            return IsNullLiteral;
        }

        /// <summary>
        /// Value extracted by an LLM according to the given schema.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.ASTLLMNodeInput? Lm { get; init; }
#else
        public global::ElevenLabs.ASTLLMNodeInput? Lm { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Lm))]
#endif
        public bool IsLm => Lm != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickLm(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.ASTLLMNodeInput? value)
        {
            value = Lm;
            return IsLm;
        }

        /// <summary>
        /// Reference to a dynamic variable.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.ASTDynamicVariableNodeInput? DynamicVariable { get; init; }
#else
        public global::ElevenLabs.ASTDynamicVariableNodeInput? DynamicVariable { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(DynamicVariable))]
#endif
        public bool IsDynamicVariable => DynamicVariable != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickDynamicVariable(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.ASTDynamicVariableNodeInput? value)
        {
            value = DynamicVariable;
            return IsDynamicVariable;
        }

        /// <summary>
        /// Evaluates to true if any child is true.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.ASTOrOperatorNodeInput? OrOperator { get; init; }
#else
        public global::ElevenLabs.ASTOrOperatorNodeInput? OrOperator { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OrOperator))]
#endif
        public bool IsOrOperator => OrOperator != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickOrOperator(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.ASTOrOperatorNodeInput? value)
        {
            value = OrOperator;
            return IsOrOperator;
        }

        /// <summary>
        /// Evaluates to true if all children are true.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.ASTAndOperatorNodeInput? AndOperator { get; init; }
#else
        public global::ElevenLabs.ASTAndOperatorNodeInput? AndOperator { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AndOperator))]
#endif
        public bool IsAndOperator => AndOperator != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickAndOperator(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.ASTAndOperatorNodeInput? value)
        {
            value = AndOperator;
            return IsAndOperator;
        }

        /// <summary>
        /// Evaluates to true if the left value equals the right.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.ASTEqualsOperatorNodeInput? EqOperator { get; init; }
#else
        public global::ElevenLabs.ASTEqualsOperatorNodeInput? EqOperator { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(EqOperator))]
#endif
        public bool IsEqOperator => EqOperator != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickEqOperator(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.ASTEqualsOperatorNodeInput? value)
        {
            value = EqOperator;
            return IsEqOperator;
        }

        /// <summary>
        /// Evaluates to true if the left value does not equal the right.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.ASTNotEqualsOperatorNodeInput? NeqOperator { get; init; }
#else
        public global::ElevenLabs.ASTNotEqualsOperatorNodeInput? NeqOperator { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(NeqOperator))]
#endif
        public bool IsNeqOperator => NeqOperator != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickNeqOperator(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.ASTNotEqualsOperatorNodeInput? value)
        {
            value = NeqOperator;
            return IsNeqOperator;
        }

        /// <summary>
        /// Evaluates to true if the left value is greater than the right.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.ASTGreaterThanOperatorNodeInput? GtOperator { get; init; }
#else
        public global::ElevenLabs.ASTGreaterThanOperatorNodeInput? GtOperator { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GtOperator))]
#endif
        public bool IsGtOperator => GtOperator != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickGtOperator(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.ASTGreaterThanOperatorNodeInput? value)
        {
            value = GtOperator;
            return IsGtOperator;
        }

        /// <summary>
        /// Evaluates to true if the left value is less than the right.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.ASTLessThanOperatorNodeInput? LtOperator { get; init; }
#else
        public global::ElevenLabs.ASTLessThanOperatorNodeInput? LtOperator { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(LtOperator))]
#endif
        public bool IsLtOperator => LtOperator != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickLtOperator(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.ASTLessThanOperatorNodeInput? value)
        {
            value = LtOperator;
            return IsLtOperator;
        }

        /// <summary>
        /// Evaluates to true if the left value is greater than or equal to the right.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.ASTGreaterThanOrEqualsOperatorNodeInput? GteOperator { get; init; }
#else
        public global::ElevenLabs.ASTGreaterThanOrEqualsOperatorNodeInput? GteOperator { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GteOperator))]
#endif
        public bool IsGteOperator => GteOperator != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickGteOperator(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.ASTGreaterThanOrEqualsOperatorNodeInput? value)
        {
            value = GteOperator;
            return IsGteOperator;
        }

        /// <summary>
        /// Evaluates to true if the left value is less than or equal to the right.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.ASTLessThanOrEqualsOperatorNodeInput? LteOperator { get; init; }
#else
        public global::ElevenLabs.ASTLessThanOrEqualsOperatorNodeInput? LteOperator { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(LteOperator))]
#endif
        public bool IsLteOperator => LteOperator != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickLteOperator(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.ASTLessThanOrEqualsOperatorNodeInput? value)
        {
            value = LteOperator;
            return IsLteOperator;
        }

        /// <summary>
        /// Adds the left and right values.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.ASTAdditionOperatorNodeInput? AddOperator { get; init; }
#else
        public global::ElevenLabs.ASTAdditionOperatorNodeInput? AddOperator { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AddOperator))]
#endif
        public bool IsAddOperator => AddOperator != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickAddOperator(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.ASTAdditionOperatorNodeInput? value)
        {
            value = AddOperator;
            return IsAddOperator;
        }

        /// <summary>
        /// Subtracts the right value from the left.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.ASTSubtractionOperatorNodeInput? SubOperator { get; init; }
#else
        public global::ElevenLabs.ASTSubtractionOperatorNodeInput? SubOperator { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SubOperator))]
#endif
        public bool IsSubOperator => SubOperator != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickSubOperator(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.ASTSubtractionOperatorNodeInput? value)
        {
            value = SubOperator;
            return IsSubOperator;
        }

        /// <summary>
        /// Multiplies the left value times the right.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.ASTMultiplicationOperatorNodeInput? MulOperator { get; init; }
#else
        public global::ElevenLabs.ASTMultiplicationOperatorNodeInput? MulOperator { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(MulOperator))]
#endif
        public bool IsMulOperator => MulOperator != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickMulOperator(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.ASTMultiplicationOperatorNodeInput? value)
        {
            value = MulOperator;
            return IsMulOperator;
        }

        /// <summary>
        /// Divides the left value by the right.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.ASTDivisionOperatorNodeInput? DivOperator { get; init; }
#else
        public global::ElevenLabs.ASTDivisionOperatorNodeInput? DivOperator { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(DivOperator))]
#endif
        public bool IsDivOperator => DivOperator != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickDivOperator(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.ASTDivisionOperatorNodeInput? value)
        {
            value = DivOperator;
            return IsDivOperator;
        }

        /// <summary>
        /// Selects one of two expressions based on whether the given condition evaluates to true.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.ASTConditionalOperatorNodeInput? ConditionalOperator { get; init; }
#else
        public global::ElevenLabs.ASTConditionalOperatorNodeInput? ConditionalOperator { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ConditionalOperator))]
#endif
        public bool IsConditionalOperator => ConditionalOperator != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickConditionalOperator(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.ASTConditionalOperatorNodeInput? value)
        {
            value = ConditionalOperator;
            return IsConditionalOperator;
        }
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ASTNodeInput(global::ElevenLabs.ASTStringNodeInput value) => new ASTNodeInput((global::ElevenLabs.ASTStringNodeInput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.ASTStringNodeInput?(ASTNodeInput @this) => @this.StringLiteral;

        /// <summary>
        /// 
        /// </summary>
        public ASTNodeInput(global::ElevenLabs.ASTStringNodeInput? value)
        {
            StringLiteral = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ASTNodeInput(global::ElevenLabs.ASTNumberNodeInput value) => new ASTNodeInput((global::ElevenLabs.ASTNumberNodeInput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.ASTNumberNodeInput?(ASTNodeInput @this) => @this.NumberLiteral;

        /// <summary>
        /// 
        /// </summary>
        public ASTNodeInput(global::ElevenLabs.ASTNumberNodeInput? value)
        {
            NumberLiteral = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ASTNodeInput(global::ElevenLabs.ASTBooleanNodeInput value) => new ASTNodeInput((global::ElevenLabs.ASTBooleanNodeInput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.ASTBooleanNodeInput?(ASTNodeInput @this) => @this.BooleanLiteral;

        /// <summary>
        /// 
        /// </summary>
        public ASTNodeInput(global::ElevenLabs.ASTBooleanNodeInput? value)
        {
            BooleanLiteral = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ASTNodeInput(global::ElevenLabs.ASTNullNodeInput value) => new ASTNodeInput((global::ElevenLabs.ASTNullNodeInput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.ASTNullNodeInput?(ASTNodeInput @this) => @this.NullLiteral;

        /// <summary>
        /// 
        /// </summary>
        public ASTNodeInput(global::ElevenLabs.ASTNullNodeInput? value)
        {
            NullLiteral = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ASTNodeInput(global::ElevenLabs.ASTLLMNodeInput value) => new ASTNodeInput((global::ElevenLabs.ASTLLMNodeInput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.ASTLLMNodeInput?(ASTNodeInput @this) => @this.Lm;

        /// <summary>
        /// 
        /// </summary>
        public ASTNodeInput(global::ElevenLabs.ASTLLMNodeInput? value)
        {
            Lm = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ASTNodeInput(global::ElevenLabs.ASTDynamicVariableNodeInput value) => new ASTNodeInput((global::ElevenLabs.ASTDynamicVariableNodeInput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.ASTDynamicVariableNodeInput?(ASTNodeInput @this) => @this.DynamicVariable;

        /// <summary>
        /// 
        /// </summary>
        public ASTNodeInput(global::ElevenLabs.ASTDynamicVariableNodeInput? value)
        {
            DynamicVariable = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ASTNodeInput(global::ElevenLabs.ASTOrOperatorNodeInput value) => new ASTNodeInput((global::ElevenLabs.ASTOrOperatorNodeInput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.ASTOrOperatorNodeInput?(ASTNodeInput @this) => @this.OrOperator;

        /// <summary>
        /// 
        /// </summary>
        public ASTNodeInput(global::ElevenLabs.ASTOrOperatorNodeInput? value)
        {
            OrOperator = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ASTNodeInput(global::ElevenLabs.ASTAndOperatorNodeInput value) => new ASTNodeInput((global::ElevenLabs.ASTAndOperatorNodeInput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.ASTAndOperatorNodeInput?(ASTNodeInput @this) => @this.AndOperator;

        /// <summary>
        /// 
        /// </summary>
        public ASTNodeInput(global::ElevenLabs.ASTAndOperatorNodeInput? value)
        {
            AndOperator = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ASTNodeInput(global::ElevenLabs.ASTEqualsOperatorNodeInput value) => new ASTNodeInput((global::ElevenLabs.ASTEqualsOperatorNodeInput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.ASTEqualsOperatorNodeInput?(ASTNodeInput @this) => @this.EqOperator;

        /// <summary>
        /// 
        /// </summary>
        public ASTNodeInput(global::ElevenLabs.ASTEqualsOperatorNodeInput? value)
        {
            EqOperator = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ASTNodeInput(global::ElevenLabs.ASTNotEqualsOperatorNodeInput value) => new ASTNodeInput((global::ElevenLabs.ASTNotEqualsOperatorNodeInput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.ASTNotEqualsOperatorNodeInput?(ASTNodeInput @this) => @this.NeqOperator;

        /// <summary>
        /// 
        /// </summary>
        public ASTNodeInput(global::ElevenLabs.ASTNotEqualsOperatorNodeInput? value)
        {
            NeqOperator = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ASTNodeInput(global::ElevenLabs.ASTGreaterThanOperatorNodeInput value) => new ASTNodeInput((global::ElevenLabs.ASTGreaterThanOperatorNodeInput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.ASTGreaterThanOperatorNodeInput?(ASTNodeInput @this) => @this.GtOperator;

        /// <summary>
        /// 
        /// </summary>
        public ASTNodeInput(global::ElevenLabs.ASTGreaterThanOperatorNodeInput? value)
        {
            GtOperator = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ASTNodeInput(global::ElevenLabs.ASTLessThanOperatorNodeInput value) => new ASTNodeInput((global::ElevenLabs.ASTLessThanOperatorNodeInput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.ASTLessThanOperatorNodeInput?(ASTNodeInput @this) => @this.LtOperator;

        /// <summary>
        /// 
        /// </summary>
        public ASTNodeInput(global::ElevenLabs.ASTLessThanOperatorNodeInput? value)
        {
            LtOperator = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ASTNodeInput(global::ElevenLabs.ASTGreaterThanOrEqualsOperatorNodeInput value) => new ASTNodeInput((global::ElevenLabs.ASTGreaterThanOrEqualsOperatorNodeInput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.ASTGreaterThanOrEqualsOperatorNodeInput?(ASTNodeInput @this) => @this.GteOperator;

        /// <summary>
        /// 
        /// </summary>
        public ASTNodeInput(global::ElevenLabs.ASTGreaterThanOrEqualsOperatorNodeInput? value)
        {
            GteOperator = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ASTNodeInput(global::ElevenLabs.ASTLessThanOrEqualsOperatorNodeInput value) => new ASTNodeInput((global::ElevenLabs.ASTLessThanOrEqualsOperatorNodeInput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.ASTLessThanOrEqualsOperatorNodeInput?(ASTNodeInput @this) => @this.LteOperator;

        /// <summary>
        /// 
        /// </summary>
        public ASTNodeInput(global::ElevenLabs.ASTLessThanOrEqualsOperatorNodeInput? value)
        {
            LteOperator = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ASTNodeInput(global::ElevenLabs.ASTAdditionOperatorNodeInput value) => new ASTNodeInput((global::ElevenLabs.ASTAdditionOperatorNodeInput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.ASTAdditionOperatorNodeInput?(ASTNodeInput @this) => @this.AddOperator;

        /// <summary>
        /// 
        /// </summary>
        public ASTNodeInput(global::ElevenLabs.ASTAdditionOperatorNodeInput? value)
        {
            AddOperator = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ASTNodeInput(global::ElevenLabs.ASTSubtractionOperatorNodeInput value) => new ASTNodeInput((global::ElevenLabs.ASTSubtractionOperatorNodeInput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.ASTSubtractionOperatorNodeInput?(ASTNodeInput @this) => @this.SubOperator;

        /// <summary>
        /// 
        /// </summary>
        public ASTNodeInput(global::ElevenLabs.ASTSubtractionOperatorNodeInput? value)
        {
            SubOperator = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ASTNodeInput(global::ElevenLabs.ASTMultiplicationOperatorNodeInput value) => new ASTNodeInput((global::ElevenLabs.ASTMultiplicationOperatorNodeInput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.ASTMultiplicationOperatorNodeInput?(ASTNodeInput @this) => @this.MulOperator;

        /// <summary>
        /// 
        /// </summary>
        public ASTNodeInput(global::ElevenLabs.ASTMultiplicationOperatorNodeInput? value)
        {
            MulOperator = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ASTNodeInput(global::ElevenLabs.ASTDivisionOperatorNodeInput value) => new ASTNodeInput((global::ElevenLabs.ASTDivisionOperatorNodeInput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.ASTDivisionOperatorNodeInput?(ASTNodeInput @this) => @this.DivOperator;

        /// <summary>
        /// 
        /// </summary>
        public ASTNodeInput(global::ElevenLabs.ASTDivisionOperatorNodeInput? value)
        {
            DivOperator = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ASTNodeInput(global::ElevenLabs.ASTConditionalOperatorNodeInput value) => new ASTNodeInput((global::ElevenLabs.ASTConditionalOperatorNodeInput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.ASTConditionalOperatorNodeInput?(ASTNodeInput @this) => @this.ConditionalOperator;

        /// <summary>
        /// 
        /// </summary>
        public ASTNodeInput(global::ElevenLabs.ASTConditionalOperatorNodeInput? value)
        {
            ConditionalOperator = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ASTNodeInput(
            global::ElevenLabs.ASTStringNodeInput? stringLiteral,
            global::ElevenLabs.ASTNumberNodeInput? numberLiteral,
            global::ElevenLabs.ASTBooleanNodeInput? booleanLiteral,
            global::ElevenLabs.ASTNullNodeInput? nullLiteral,
            global::ElevenLabs.ASTLLMNodeInput? lm,
            global::ElevenLabs.ASTDynamicVariableNodeInput? dynamicVariable,
            global::ElevenLabs.ASTOrOperatorNodeInput? orOperator,
            global::ElevenLabs.ASTAndOperatorNodeInput? andOperator,
            global::ElevenLabs.ASTEqualsOperatorNodeInput? eqOperator,
            global::ElevenLabs.ASTNotEqualsOperatorNodeInput? neqOperator,
            global::ElevenLabs.ASTGreaterThanOperatorNodeInput? gtOperator,
            global::ElevenLabs.ASTLessThanOperatorNodeInput? ltOperator,
            global::ElevenLabs.ASTGreaterThanOrEqualsOperatorNodeInput? gteOperator,
            global::ElevenLabs.ASTLessThanOrEqualsOperatorNodeInput? lteOperator,
            global::ElevenLabs.ASTAdditionOperatorNodeInput? addOperator,
            global::ElevenLabs.ASTSubtractionOperatorNodeInput? subOperator,
            global::ElevenLabs.ASTMultiplicationOperatorNodeInput? mulOperator,
            global::ElevenLabs.ASTDivisionOperatorNodeInput? divOperator,
            global::ElevenLabs.ASTConditionalOperatorNodeInput? conditionalOperator
            )
        {
            StringLiteral = stringLiteral;
            NumberLiteral = numberLiteral;
            BooleanLiteral = booleanLiteral;
            NullLiteral = nullLiteral;
            Lm = lm;
            DynamicVariable = dynamicVariable;
            OrOperator = orOperator;
            AndOperator = andOperator;
            EqOperator = eqOperator;
            NeqOperator = neqOperator;
            GtOperator = gtOperator;
            LtOperator = ltOperator;
            GteOperator = gteOperator;
            LteOperator = lteOperator;
            AddOperator = addOperator;
            SubOperator = subOperator;
            MulOperator = mulOperator;
            DivOperator = divOperator;
            ConditionalOperator = conditionalOperator;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ConditionalOperator as object ??
            DivOperator as object ??
            MulOperator as object ??
            SubOperator as object ??
            AddOperator as object ??
            LteOperator as object ??
            GteOperator as object ??
            LtOperator as object ??
            GtOperator as object ??
            NeqOperator as object ??
            EqOperator as object ??
            AndOperator as object ??
            OrOperator as object ??
            DynamicVariable as object ??
            Lm as object ??
            NullLiteral as object ??
            BooleanLiteral as object ??
            NumberLiteral as object ??
            StringLiteral as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            StringLiteral?.ToString() ??
            NumberLiteral?.ToString() ??
            BooleanLiteral?.ToString() ??
            NullLiteral?.ToString() ??
            Lm?.ToString() ??
            DynamicVariable?.ToString() ??
            OrOperator?.ToString() ??
            AndOperator?.ToString() ??
            EqOperator?.ToString() ??
            NeqOperator?.ToString() ??
            GtOperator?.ToString() ??
            LtOperator?.ToString() ??
            GteOperator?.ToString() ??
            LteOperator?.ToString() ??
            AddOperator?.ToString() ??
            SubOperator?.ToString() ??
            MulOperator?.ToString() ??
            DivOperator?.ToString() ??
            ConditionalOperator?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsStringLiteral && !IsNumberLiteral && !IsBooleanLiteral && !IsNullLiteral && !IsLm && !IsDynamicVariable && !IsOrOperator && !IsAndOperator && !IsEqOperator && !IsNeqOperator && !IsGtOperator && !IsLtOperator && !IsGteOperator && !IsLteOperator && !IsAddOperator && !IsSubOperator && !IsMulOperator && !IsDivOperator && !IsConditionalOperator || !IsStringLiteral && IsNumberLiteral && !IsBooleanLiteral && !IsNullLiteral && !IsLm && !IsDynamicVariable && !IsOrOperator && !IsAndOperator && !IsEqOperator && !IsNeqOperator && !IsGtOperator && !IsLtOperator && !IsGteOperator && !IsLteOperator && !IsAddOperator && !IsSubOperator && !IsMulOperator && !IsDivOperator && !IsConditionalOperator || !IsStringLiteral && !IsNumberLiteral && IsBooleanLiteral && !IsNullLiteral && !IsLm && !IsDynamicVariable && !IsOrOperator && !IsAndOperator && !IsEqOperator && !IsNeqOperator && !IsGtOperator && !IsLtOperator && !IsGteOperator && !IsLteOperator && !IsAddOperator && !IsSubOperator && !IsMulOperator && !IsDivOperator && !IsConditionalOperator || !IsStringLiteral && !IsNumberLiteral && !IsBooleanLiteral && IsNullLiteral && !IsLm && !IsDynamicVariable && !IsOrOperator && !IsAndOperator && !IsEqOperator && !IsNeqOperator && !IsGtOperator && !IsLtOperator && !IsGteOperator && !IsLteOperator && !IsAddOperator && !IsSubOperator && !IsMulOperator && !IsDivOperator && !IsConditionalOperator || !IsStringLiteral && !IsNumberLiteral && !IsBooleanLiteral && !IsNullLiteral && IsLm && !IsDynamicVariable && !IsOrOperator && !IsAndOperator && !IsEqOperator && !IsNeqOperator && !IsGtOperator && !IsLtOperator && !IsGteOperator && !IsLteOperator && !IsAddOperator && !IsSubOperator && !IsMulOperator && !IsDivOperator && !IsConditionalOperator || !IsStringLiteral && !IsNumberLiteral && !IsBooleanLiteral && !IsNullLiteral && !IsLm && IsDynamicVariable && !IsOrOperator && !IsAndOperator && !IsEqOperator && !IsNeqOperator && !IsGtOperator && !IsLtOperator && !IsGteOperator && !IsLteOperator && !IsAddOperator && !IsSubOperator && !IsMulOperator && !IsDivOperator && !IsConditionalOperator || !IsStringLiteral && !IsNumberLiteral && !IsBooleanLiteral && !IsNullLiteral && !IsLm && !IsDynamicVariable && IsOrOperator && !IsAndOperator && !IsEqOperator && !IsNeqOperator && !IsGtOperator && !IsLtOperator && !IsGteOperator && !IsLteOperator && !IsAddOperator && !IsSubOperator && !IsMulOperator && !IsDivOperator && !IsConditionalOperator || !IsStringLiteral && !IsNumberLiteral && !IsBooleanLiteral && !IsNullLiteral && !IsLm && !IsDynamicVariable && !IsOrOperator && IsAndOperator && !IsEqOperator && !IsNeqOperator && !IsGtOperator && !IsLtOperator && !IsGteOperator && !IsLteOperator && !IsAddOperator && !IsSubOperator && !IsMulOperator && !IsDivOperator && !IsConditionalOperator || !IsStringLiteral && !IsNumberLiteral && !IsBooleanLiteral && !IsNullLiteral && !IsLm && !IsDynamicVariable && !IsOrOperator && !IsAndOperator && IsEqOperator && !IsNeqOperator && !IsGtOperator && !IsLtOperator && !IsGteOperator && !IsLteOperator && !IsAddOperator && !IsSubOperator && !IsMulOperator && !IsDivOperator && !IsConditionalOperator || !IsStringLiteral && !IsNumberLiteral && !IsBooleanLiteral && !IsNullLiteral && !IsLm && !IsDynamicVariable && !IsOrOperator && !IsAndOperator && !IsEqOperator && IsNeqOperator && !IsGtOperator && !IsLtOperator && !IsGteOperator && !IsLteOperator && !IsAddOperator && !IsSubOperator && !IsMulOperator && !IsDivOperator && !IsConditionalOperator || !IsStringLiteral && !IsNumberLiteral && !IsBooleanLiteral && !IsNullLiteral && !IsLm && !IsDynamicVariable && !IsOrOperator && !IsAndOperator && !IsEqOperator && !IsNeqOperator && IsGtOperator && !IsLtOperator && !IsGteOperator && !IsLteOperator && !IsAddOperator && !IsSubOperator && !IsMulOperator && !IsDivOperator && !IsConditionalOperator || !IsStringLiteral && !IsNumberLiteral && !IsBooleanLiteral && !IsNullLiteral && !IsLm && !IsDynamicVariable && !IsOrOperator && !IsAndOperator && !IsEqOperator && !IsNeqOperator && !IsGtOperator && IsLtOperator && !IsGteOperator && !IsLteOperator && !IsAddOperator && !IsSubOperator && !IsMulOperator && !IsDivOperator && !IsConditionalOperator || !IsStringLiteral && !IsNumberLiteral && !IsBooleanLiteral && !IsNullLiteral && !IsLm && !IsDynamicVariable && !IsOrOperator && !IsAndOperator && !IsEqOperator && !IsNeqOperator && !IsGtOperator && !IsLtOperator && IsGteOperator && !IsLteOperator && !IsAddOperator && !IsSubOperator && !IsMulOperator && !IsDivOperator && !IsConditionalOperator || !IsStringLiteral && !IsNumberLiteral && !IsBooleanLiteral && !IsNullLiteral && !IsLm && !IsDynamicVariable && !IsOrOperator && !IsAndOperator && !IsEqOperator && !IsNeqOperator && !IsGtOperator && !IsLtOperator && !IsGteOperator && IsLteOperator && !IsAddOperator && !IsSubOperator && !IsMulOperator && !IsDivOperator && !IsConditionalOperator || !IsStringLiteral && !IsNumberLiteral && !IsBooleanLiteral && !IsNullLiteral && !IsLm && !IsDynamicVariable && !IsOrOperator && !IsAndOperator && !IsEqOperator && !IsNeqOperator && !IsGtOperator && !IsLtOperator && !IsGteOperator && !IsLteOperator && IsAddOperator && !IsSubOperator && !IsMulOperator && !IsDivOperator && !IsConditionalOperator || !IsStringLiteral && !IsNumberLiteral && !IsBooleanLiteral && !IsNullLiteral && !IsLm && !IsDynamicVariable && !IsOrOperator && !IsAndOperator && !IsEqOperator && !IsNeqOperator && !IsGtOperator && !IsLtOperator && !IsGteOperator && !IsLteOperator && !IsAddOperator && IsSubOperator && !IsMulOperator && !IsDivOperator && !IsConditionalOperator || !IsStringLiteral && !IsNumberLiteral && !IsBooleanLiteral && !IsNullLiteral && !IsLm && !IsDynamicVariable && !IsOrOperator && !IsAndOperator && !IsEqOperator && !IsNeqOperator && !IsGtOperator && !IsLtOperator && !IsGteOperator && !IsLteOperator && !IsAddOperator && !IsSubOperator && IsMulOperator && !IsDivOperator && !IsConditionalOperator || !IsStringLiteral && !IsNumberLiteral && !IsBooleanLiteral && !IsNullLiteral && !IsLm && !IsDynamicVariable && !IsOrOperator && !IsAndOperator && !IsEqOperator && !IsNeqOperator && !IsGtOperator && !IsLtOperator && !IsGteOperator && !IsLteOperator && !IsAddOperator && !IsSubOperator && !IsMulOperator && IsDivOperator && !IsConditionalOperator || !IsStringLiteral && !IsNumberLiteral && !IsBooleanLiteral && !IsNullLiteral && !IsLm && !IsDynamicVariable && !IsOrOperator && !IsAndOperator && !IsEqOperator && !IsNeqOperator && !IsGtOperator && !IsLtOperator && !IsGteOperator && !IsLteOperator && !IsAddOperator && !IsSubOperator && !IsMulOperator && !IsDivOperator && IsConditionalOperator;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::ElevenLabs.ASTStringNodeInput, TResult>? stringLiteral = null,
            global::System.Func<global::ElevenLabs.ASTNumberNodeInput, TResult>? numberLiteral = null,
            global::System.Func<global::ElevenLabs.ASTBooleanNodeInput, TResult>? booleanLiteral = null,
            global::System.Func<global::ElevenLabs.ASTNullNodeInput, TResult>? nullLiteral = null,
            global::System.Func<global::ElevenLabs.ASTLLMNodeInput?, TResult>? lm = null,
            global::System.Func<global::ElevenLabs.ASTDynamicVariableNodeInput, TResult>? dynamicVariable = null,
            global::System.Func<global::ElevenLabs.ASTOrOperatorNodeInput, TResult>? orOperator = null,
            global::System.Func<global::ElevenLabs.ASTAndOperatorNodeInput, TResult>? andOperator = null,
            global::System.Func<global::ElevenLabs.ASTEqualsOperatorNodeInput, TResult>? eqOperator = null,
            global::System.Func<global::ElevenLabs.ASTNotEqualsOperatorNodeInput, TResult>? neqOperator = null,
            global::System.Func<global::ElevenLabs.ASTGreaterThanOperatorNodeInput, TResult>? gtOperator = null,
            global::System.Func<global::ElevenLabs.ASTLessThanOperatorNodeInput, TResult>? ltOperator = null,
            global::System.Func<global::ElevenLabs.ASTGreaterThanOrEqualsOperatorNodeInput, TResult>? gteOperator = null,
            global::System.Func<global::ElevenLabs.ASTLessThanOrEqualsOperatorNodeInput, TResult>? lteOperator = null,
            global::System.Func<global::ElevenLabs.ASTAdditionOperatorNodeInput, TResult>? addOperator = null,
            global::System.Func<global::ElevenLabs.ASTSubtractionOperatorNodeInput, TResult>? subOperator = null,
            global::System.Func<global::ElevenLabs.ASTMultiplicationOperatorNodeInput, TResult>? mulOperator = null,
            global::System.Func<global::ElevenLabs.ASTDivisionOperatorNodeInput, TResult>? divOperator = null,
            global::System.Func<global::ElevenLabs.ASTConditionalOperatorNodeInput, TResult>? conditionalOperator = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsStringLiteral && stringLiteral != null)
            {
                return stringLiteral(StringLiteral!);
            }
            else if (IsNumberLiteral && numberLiteral != null)
            {
                return numberLiteral(NumberLiteral!);
            }
            else if (IsBooleanLiteral && booleanLiteral != null)
            {
                return booleanLiteral(BooleanLiteral!);
            }
            else if (IsNullLiteral && nullLiteral != null)
            {
                return nullLiteral(NullLiteral!);
            }
            else if (IsLm && lm != null)
            {
                return lm(Lm!);
            }
            else if (IsDynamicVariable && dynamicVariable != null)
            {
                return dynamicVariable(DynamicVariable!);
            }
            else if (IsOrOperator && orOperator != null)
            {
                return orOperator(OrOperator!);
            }
            else if (IsAndOperator && andOperator != null)
            {
                return andOperator(AndOperator!);
            }
            else if (IsEqOperator && eqOperator != null)
            {
                return eqOperator(EqOperator!);
            }
            else if (IsNeqOperator && neqOperator != null)
            {
                return neqOperator(NeqOperator!);
            }
            else if (IsGtOperator && gtOperator != null)
            {
                return gtOperator(GtOperator!);
            }
            else if (IsLtOperator && ltOperator != null)
            {
                return ltOperator(LtOperator!);
            }
            else if (IsGteOperator && gteOperator != null)
            {
                return gteOperator(GteOperator!);
            }
            else if (IsLteOperator && lteOperator != null)
            {
                return lteOperator(LteOperator!);
            }
            else if (IsAddOperator && addOperator != null)
            {
                return addOperator(AddOperator!);
            }
            else if (IsSubOperator && subOperator != null)
            {
                return subOperator(SubOperator!);
            }
            else if (IsMulOperator && mulOperator != null)
            {
                return mulOperator(MulOperator!);
            }
            else if (IsDivOperator && divOperator != null)
            {
                return divOperator(DivOperator!);
            }
            else if (IsConditionalOperator && conditionalOperator != null)
            {
                return conditionalOperator(ConditionalOperator!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::ElevenLabs.ASTStringNodeInput>? stringLiteral = null,

            global::System.Action<global::ElevenLabs.ASTNumberNodeInput>? numberLiteral = null,

            global::System.Action<global::ElevenLabs.ASTBooleanNodeInput>? booleanLiteral = null,

            global::System.Action<global::ElevenLabs.ASTNullNodeInput>? nullLiteral = null,

            global::System.Action<global::ElevenLabs.ASTLLMNodeInput?>? lm = null,

            global::System.Action<global::ElevenLabs.ASTDynamicVariableNodeInput>? dynamicVariable = null,

            global::System.Action<global::ElevenLabs.ASTOrOperatorNodeInput>? orOperator = null,

            global::System.Action<global::ElevenLabs.ASTAndOperatorNodeInput>? andOperator = null,

            global::System.Action<global::ElevenLabs.ASTEqualsOperatorNodeInput>? eqOperator = null,

            global::System.Action<global::ElevenLabs.ASTNotEqualsOperatorNodeInput>? neqOperator = null,

            global::System.Action<global::ElevenLabs.ASTGreaterThanOperatorNodeInput>? gtOperator = null,

            global::System.Action<global::ElevenLabs.ASTLessThanOperatorNodeInput>? ltOperator = null,

            global::System.Action<global::ElevenLabs.ASTGreaterThanOrEqualsOperatorNodeInput>? gteOperator = null,

            global::System.Action<global::ElevenLabs.ASTLessThanOrEqualsOperatorNodeInput>? lteOperator = null,

            global::System.Action<global::ElevenLabs.ASTAdditionOperatorNodeInput>? addOperator = null,

            global::System.Action<global::ElevenLabs.ASTSubtractionOperatorNodeInput>? subOperator = null,

            global::System.Action<global::ElevenLabs.ASTMultiplicationOperatorNodeInput>? mulOperator = null,

            global::System.Action<global::ElevenLabs.ASTDivisionOperatorNodeInput>? divOperator = null,

            global::System.Action<global::ElevenLabs.ASTConditionalOperatorNodeInput>? conditionalOperator = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsStringLiteral)
            {
                stringLiteral?.Invoke(StringLiteral!);
            }
            else if (IsNumberLiteral)
            {
                numberLiteral?.Invoke(NumberLiteral!);
            }
            else if (IsBooleanLiteral)
            {
                booleanLiteral?.Invoke(BooleanLiteral!);
            }
            else if (IsNullLiteral)
            {
                nullLiteral?.Invoke(NullLiteral!);
            }
            else if (IsLm)
            {
                lm?.Invoke(Lm!);
            }
            else if (IsDynamicVariable)
            {
                dynamicVariable?.Invoke(DynamicVariable!);
            }
            else if (IsOrOperator)
            {
                orOperator?.Invoke(OrOperator!);
            }
            else if (IsAndOperator)
            {
                andOperator?.Invoke(AndOperator!);
            }
            else if (IsEqOperator)
            {
                eqOperator?.Invoke(EqOperator!);
            }
            else if (IsNeqOperator)
            {
                neqOperator?.Invoke(NeqOperator!);
            }
            else if (IsGtOperator)
            {
                gtOperator?.Invoke(GtOperator!);
            }
            else if (IsLtOperator)
            {
                ltOperator?.Invoke(LtOperator!);
            }
            else if (IsGteOperator)
            {
                gteOperator?.Invoke(GteOperator!);
            }
            else if (IsLteOperator)
            {
                lteOperator?.Invoke(LteOperator!);
            }
            else if (IsAddOperator)
            {
                addOperator?.Invoke(AddOperator!);
            }
            else if (IsSubOperator)
            {
                subOperator?.Invoke(SubOperator!);
            }
            else if (IsMulOperator)
            {
                mulOperator?.Invoke(MulOperator!);
            }
            else if (IsDivOperator)
            {
                divOperator?.Invoke(DivOperator!);
            }
            else if (IsConditionalOperator)
            {
                conditionalOperator?.Invoke(ConditionalOperator!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::ElevenLabs.ASTStringNodeInput>? stringLiteral = null,
            global::System.Action<global::ElevenLabs.ASTNumberNodeInput>? numberLiteral = null,
            global::System.Action<global::ElevenLabs.ASTBooleanNodeInput>? booleanLiteral = null,
            global::System.Action<global::ElevenLabs.ASTNullNodeInput>? nullLiteral = null,
            global::System.Action<global::ElevenLabs.ASTLLMNodeInput?>? lm = null,
            global::System.Action<global::ElevenLabs.ASTDynamicVariableNodeInput>? dynamicVariable = null,
            global::System.Action<global::ElevenLabs.ASTOrOperatorNodeInput>? orOperator = null,
            global::System.Action<global::ElevenLabs.ASTAndOperatorNodeInput>? andOperator = null,
            global::System.Action<global::ElevenLabs.ASTEqualsOperatorNodeInput>? eqOperator = null,
            global::System.Action<global::ElevenLabs.ASTNotEqualsOperatorNodeInput>? neqOperator = null,
            global::System.Action<global::ElevenLabs.ASTGreaterThanOperatorNodeInput>? gtOperator = null,
            global::System.Action<global::ElevenLabs.ASTLessThanOperatorNodeInput>? ltOperator = null,
            global::System.Action<global::ElevenLabs.ASTGreaterThanOrEqualsOperatorNodeInput>? gteOperator = null,
            global::System.Action<global::ElevenLabs.ASTLessThanOrEqualsOperatorNodeInput>? lteOperator = null,
            global::System.Action<global::ElevenLabs.ASTAdditionOperatorNodeInput>? addOperator = null,
            global::System.Action<global::ElevenLabs.ASTSubtractionOperatorNodeInput>? subOperator = null,
            global::System.Action<global::ElevenLabs.ASTMultiplicationOperatorNodeInput>? mulOperator = null,
            global::System.Action<global::ElevenLabs.ASTDivisionOperatorNodeInput>? divOperator = null,
            global::System.Action<global::ElevenLabs.ASTConditionalOperatorNodeInput>? conditionalOperator = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsStringLiteral)
            {
                stringLiteral?.Invoke(StringLiteral!);
            }
            else if (IsNumberLiteral)
            {
                numberLiteral?.Invoke(NumberLiteral!);
            }
            else if (IsBooleanLiteral)
            {
                booleanLiteral?.Invoke(BooleanLiteral!);
            }
            else if (IsNullLiteral)
            {
                nullLiteral?.Invoke(NullLiteral!);
            }
            else if (IsLm)
            {
                lm?.Invoke(Lm!);
            }
            else if (IsDynamicVariable)
            {
                dynamicVariable?.Invoke(DynamicVariable!);
            }
            else if (IsOrOperator)
            {
                orOperator?.Invoke(OrOperator!);
            }
            else if (IsAndOperator)
            {
                andOperator?.Invoke(AndOperator!);
            }
            else if (IsEqOperator)
            {
                eqOperator?.Invoke(EqOperator!);
            }
            else if (IsNeqOperator)
            {
                neqOperator?.Invoke(NeqOperator!);
            }
            else if (IsGtOperator)
            {
                gtOperator?.Invoke(GtOperator!);
            }
            else if (IsLtOperator)
            {
                ltOperator?.Invoke(LtOperator!);
            }
            else if (IsGteOperator)
            {
                gteOperator?.Invoke(GteOperator!);
            }
            else if (IsLteOperator)
            {
                lteOperator?.Invoke(LteOperator!);
            }
            else if (IsAddOperator)
            {
                addOperator?.Invoke(AddOperator!);
            }
            else if (IsSubOperator)
            {
                subOperator?.Invoke(SubOperator!);
            }
            else if (IsMulOperator)
            {
                mulOperator?.Invoke(MulOperator!);
            }
            else if (IsDivOperator)
            {
                divOperator?.Invoke(DivOperator!);
            }
            else if (IsConditionalOperator)
            {
                conditionalOperator?.Invoke(ConditionalOperator!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                StringLiteral,
                typeof(global::ElevenLabs.ASTStringNodeInput),
                NumberLiteral,
                typeof(global::ElevenLabs.ASTNumberNodeInput),
                BooleanLiteral,
                typeof(global::ElevenLabs.ASTBooleanNodeInput),
                NullLiteral,
                typeof(global::ElevenLabs.ASTNullNodeInput),
                Lm,
                typeof(global::ElevenLabs.ASTLLMNodeInput),
                DynamicVariable,
                typeof(global::ElevenLabs.ASTDynamicVariableNodeInput),
                OrOperator,
                typeof(global::ElevenLabs.ASTOrOperatorNodeInput),
                AndOperator,
                typeof(global::ElevenLabs.ASTAndOperatorNodeInput),
                EqOperator,
                typeof(global::ElevenLabs.ASTEqualsOperatorNodeInput),
                NeqOperator,
                typeof(global::ElevenLabs.ASTNotEqualsOperatorNodeInput),
                GtOperator,
                typeof(global::ElevenLabs.ASTGreaterThanOperatorNodeInput),
                LtOperator,
                typeof(global::ElevenLabs.ASTLessThanOperatorNodeInput),
                GteOperator,
                typeof(global::ElevenLabs.ASTGreaterThanOrEqualsOperatorNodeInput),
                LteOperator,
                typeof(global::ElevenLabs.ASTLessThanOrEqualsOperatorNodeInput),
                AddOperator,
                typeof(global::ElevenLabs.ASTAdditionOperatorNodeInput),
                SubOperator,
                typeof(global::ElevenLabs.ASTSubtractionOperatorNodeInput),
                MulOperator,
                typeof(global::ElevenLabs.ASTMultiplicationOperatorNodeInput),
                DivOperator,
                typeof(global::ElevenLabs.ASTDivisionOperatorNodeInput),
                ConditionalOperator,
                typeof(global::ElevenLabs.ASTConditionalOperatorNodeInput),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;

            return global::System.Linq.Enumerable.Aggregate(fields, offset, HashCodeAggregator);
        }

        /// <summary>
        /// 
        /// </summary>
        public bool Equals(ASTNodeInput other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.ASTStringNodeInput?>.Default.Equals(StringLiteral, other.StringLiteral) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.ASTNumberNodeInput?>.Default.Equals(NumberLiteral, other.NumberLiteral) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.ASTBooleanNodeInput?>.Default.Equals(BooleanLiteral, other.BooleanLiteral) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.ASTNullNodeInput?>.Default.Equals(NullLiteral, other.NullLiteral) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.ASTLLMNodeInput?>.Default.Equals(Lm, other.Lm) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.ASTDynamicVariableNodeInput?>.Default.Equals(DynamicVariable, other.DynamicVariable) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.ASTOrOperatorNodeInput?>.Default.Equals(OrOperator, other.OrOperator) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.ASTAndOperatorNodeInput?>.Default.Equals(AndOperator, other.AndOperator) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.ASTEqualsOperatorNodeInput?>.Default.Equals(EqOperator, other.EqOperator) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.ASTNotEqualsOperatorNodeInput?>.Default.Equals(NeqOperator, other.NeqOperator) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.ASTGreaterThanOperatorNodeInput?>.Default.Equals(GtOperator, other.GtOperator) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.ASTLessThanOperatorNodeInput?>.Default.Equals(LtOperator, other.LtOperator) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.ASTGreaterThanOrEqualsOperatorNodeInput?>.Default.Equals(GteOperator, other.GteOperator) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.ASTLessThanOrEqualsOperatorNodeInput?>.Default.Equals(LteOperator, other.LteOperator) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.ASTAdditionOperatorNodeInput?>.Default.Equals(AddOperator, other.AddOperator) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.ASTSubtractionOperatorNodeInput?>.Default.Equals(SubOperator, other.SubOperator) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.ASTMultiplicationOperatorNodeInput?>.Default.Equals(MulOperator, other.MulOperator) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.ASTDivisionOperatorNodeInput?>.Default.Equals(DivOperator, other.DivOperator) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.ASTConditionalOperatorNodeInput?>.Default.Equals(ConditionalOperator, other.ConditionalOperator) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ASTNodeInput obj1, ASTNodeInput obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ASTNodeInput>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ASTNodeInput obj1, ASTNodeInput obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ASTNodeInput o && Equals(o);
        }
    }
}
