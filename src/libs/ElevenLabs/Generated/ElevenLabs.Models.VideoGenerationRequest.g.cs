#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct VideoGenerationRequest : global::System.IEquatable<VideoGenerationRequest>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::ElevenLabs.VideoGenerationRequestDiscriminatorModelId? ModelId { get; }

        /// <summary>
        /// Request body for the Creatify Aurora lipsync video model.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.CreatifyAuroraRequest? CreatifyAurora { get; init; }
#else
        public global::ElevenLabs.CreatifyAuroraRequest? CreatifyAurora { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CreatifyAurora))]
#endif
        public bool IsCreatifyAurora => CreatifyAurora != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickCreatifyAurora(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.CreatifyAuroraRequest? value)
        {
            value = CreatifyAurora;
            return IsCreatifyAurora;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::ElevenLabs.CreatifyAuroraRequest PickCreatifyAurora() => IsCreatifyAurora
            ? CreatifyAurora!
            : throw new global::System.InvalidOperationException($"Expected union variant 'CreatifyAurora' but the value was {ToString()}.");

        /// <summary>
        /// Request body for the Google Veo 3.1 video model.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.Veo31Request? Veo31Generate001 { get; init; }
#else
        public global::ElevenLabs.Veo31Request? Veo31Generate001 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Veo31Generate001))]
#endif
        public bool IsVeo31Generate001 => Veo31Generate001 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickVeo31Generate001(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.Veo31Request? value)
        {
            value = Veo31Generate001;
            return IsVeo31Generate001;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::ElevenLabs.Veo31Request PickVeo31Generate001() => IsVeo31Generate001
            ? Veo31Generate001!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Veo31Generate001' but the value was {ToString()}.");

        /// <summary>
        /// Request body for the Google Veo 3.1 Fast video model.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.Veo31FastRequest? Veo31FastGenerate001 { get; init; }
#else
        public global::ElevenLabs.Veo31FastRequest? Veo31FastGenerate001 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Veo31FastGenerate001))]
#endif
        public bool IsVeo31FastGenerate001 => Veo31FastGenerate001 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickVeo31FastGenerate001(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.Veo31FastRequest? value)
        {
            value = Veo31FastGenerate001;
            return IsVeo31FastGenerate001;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::ElevenLabs.Veo31FastRequest PickVeo31FastGenerate001() => IsVeo31FastGenerate001
            ? Veo31FastGenerate001!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Veo31FastGenerate001' but the value was {ToString()}.");

        /// <summary>
        /// Request body for the ByteDance Seedance 2.0 video model.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.BytedanceSeedance2Request? BytedanceSeedanceV2 { get; init; }
#else
        public global::ElevenLabs.BytedanceSeedance2Request? BytedanceSeedanceV2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BytedanceSeedanceV2))]
#endif
        public bool IsBytedanceSeedanceV2 => BytedanceSeedanceV2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickBytedanceSeedanceV2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.BytedanceSeedance2Request? value)
        {
            value = BytedanceSeedanceV2;
            return IsBytedanceSeedanceV2;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::ElevenLabs.BytedanceSeedance2Request PickBytedanceSeedanceV2() => IsBytedanceSeedanceV2
            ? BytedanceSeedanceV2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'BytedanceSeedanceV2' but the value was {ToString()}.");

        /// <summary>
        /// Request body for the ByteDance Seedance 2.0 Fast video model.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.BytedanceSeedance2FastRequest? BytedanceSeedanceV2Fast { get; init; }
#else
        public global::ElevenLabs.BytedanceSeedance2FastRequest? BytedanceSeedanceV2Fast { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BytedanceSeedanceV2Fast))]
#endif
        public bool IsBytedanceSeedanceV2Fast => BytedanceSeedanceV2Fast != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickBytedanceSeedanceV2Fast(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.BytedanceSeedance2FastRequest? value)
        {
            value = BytedanceSeedanceV2Fast;
            return IsBytedanceSeedanceV2Fast;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::ElevenLabs.BytedanceSeedance2FastRequest PickBytedanceSeedanceV2Fast() => IsBytedanceSeedanceV2Fast
            ? BytedanceSeedanceV2Fast!
            : throw new global::System.InvalidOperationException($"Expected union variant 'BytedanceSeedanceV2Fast' but the value was {ToString()}.");

        /// <summary>
        /// Request body for the ByteDance Seedance 2.0 Mini video model.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.BytedanceSeedance2MiniRequest? BytedanceSeedanceV2Mini { get; init; }
#else
        public global::ElevenLabs.BytedanceSeedance2MiniRequest? BytedanceSeedanceV2Mini { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BytedanceSeedanceV2Mini))]
#endif
        public bool IsBytedanceSeedanceV2Mini => BytedanceSeedanceV2Mini != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickBytedanceSeedanceV2Mini(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.BytedanceSeedance2MiniRequest? value)
        {
            value = BytedanceSeedanceV2Mini;
            return IsBytedanceSeedanceV2Mini;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::ElevenLabs.BytedanceSeedance2MiniRequest PickBytedanceSeedanceV2Mini() => IsBytedanceSeedanceV2Mini
            ? BytedanceSeedanceV2Mini!
            : throw new global::System.InvalidOperationException($"Expected union variant 'BytedanceSeedanceV2Mini' but the value was {ToString()}.");

        /// <summary>
        /// Request body for the ByteDance Seedance 2.5 video model.<br/>
        /// Diverges from the Seedance 2.0 public shape: 480p/720p only, durations up<br/>
        /// to 30s, larger reference caps, audio-only input allowed, and no ``seed``<br/>
        /// (Ark tolerates it but does not honour it).
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.BytedanceSeedance25Request? BytedanceSeedanceV25 { get; init; }
#else
        public global::ElevenLabs.BytedanceSeedance25Request? BytedanceSeedanceV25 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BytedanceSeedanceV25))]
#endif
        public bool IsBytedanceSeedanceV25 => BytedanceSeedanceV25 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickBytedanceSeedanceV25(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.BytedanceSeedance25Request? value)
        {
            value = BytedanceSeedanceV25;
            return IsBytedanceSeedanceV25;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::ElevenLabs.BytedanceSeedance25Request PickBytedanceSeedanceV25() => IsBytedanceSeedanceV25
            ? BytedanceSeedanceV25!
            : throw new global::System.InvalidOperationException($"Expected union variant 'BytedanceSeedanceV25' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator VideoGenerationRequest(global::ElevenLabs.CreatifyAuroraRequest value) => new VideoGenerationRequest((global::ElevenLabs.CreatifyAuroraRequest?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.CreatifyAuroraRequest?(VideoGenerationRequest @this) => @this.CreatifyAurora;

        /// <summary>
        /// 
        /// </summary>
        public VideoGenerationRequest(global::ElevenLabs.CreatifyAuroraRequest? value)
        {
            CreatifyAurora = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static VideoGenerationRequest FromCreatifyAurora(global::ElevenLabs.CreatifyAuroraRequest? value) => new VideoGenerationRequest(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator VideoGenerationRequest(global::ElevenLabs.Veo31Request value) => new VideoGenerationRequest((global::ElevenLabs.Veo31Request?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.Veo31Request?(VideoGenerationRequest @this) => @this.Veo31Generate001;

        /// <summary>
        /// 
        /// </summary>
        public VideoGenerationRequest(global::ElevenLabs.Veo31Request? value)
        {
            Veo31Generate001 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static VideoGenerationRequest FromVeo31Generate001(global::ElevenLabs.Veo31Request? value) => new VideoGenerationRequest(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator VideoGenerationRequest(global::ElevenLabs.Veo31FastRequest value) => new VideoGenerationRequest((global::ElevenLabs.Veo31FastRequest?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.Veo31FastRequest?(VideoGenerationRequest @this) => @this.Veo31FastGenerate001;

        /// <summary>
        /// 
        /// </summary>
        public VideoGenerationRequest(global::ElevenLabs.Veo31FastRequest? value)
        {
            Veo31FastGenerate001 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static VideoGenerationRequest FromVeo31FastGenerate001(global::ElevenLabs.Veo31FastRequest? value) => new VideoGenerationRequest(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator VideoGenerationRequest(global::ElevenLabs.BytedanceSeedance2Request value) => new VideoGenerationRequest((global::ElevenLabs.BytedanceSeedance2Request?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.BytedanceSeedance2Request?(VideoGenerationRequest @this) => @this.BytedanceSeedanceV2;

        /// <summary>
        /// 
        /// </summary>
        public VideoGenerationRequest(global::ElevenLabs.BytedanceSeedance2Request? value)
        {
            BytedanceSeedanceV2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static VideoGenerationRequest FromBytedanceSeedanceV2(global::ElevenLabs.BytedanceSeedance2Request? value) => new VideoGenerationRequest(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator VideoGenerationRequest(global::ElevenLabs.BytedanceSeedance2FastRequest value) => new VideoGenerationRequest((global::ElevenLabs.BytedanceSeedance2FastRequest?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.BytedanceSeedance2FastRequest?(VideoGenerationRequest @this) => @this.BytedanceSeedanceV2Fast;

        /// <summary>
        /// 
        /// </summary>
        public VideoGenerationRequest(global::ElevenLabs.BytedanceSeedance2FastRequest? value)
        {
            BytedanceSeedanceV2Fast = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static VideoGenerationRequest FromBytedanceSeedanceV2Fast(global::ElevenLabs.BytedanceSeedance2FastRequest? value) => new VideoGenerationRequest(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator VideoGenerationRequest(global::ElevenLabs.BytedanceSeedance2MiniRequest value) => new VideoGenerationRequest((global::ElevenLabs.BytedanceSeedance2MiniRequest?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.BytedanceSeedance2MiniRequest?(VideoGenerationRequest @this) => @this.BytedanceSeedanceV2Mini;

        /// <summary>
        /// 
        /// </summary>
        public VideoGenerationRequest(global::ElevenLabs.BytedanceSeedance2MiniRequest? value)
        {
            BytedanceSeedanceV2Mini = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static VideoGenerationRequest FromBytedanceSeedanceV2Mini(global::ElevenLabs.BytedanceSeedance2MiniRequest? value) => new VideoGenerationRequest(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator VideoGenerationRequest(global::ElevenLabs.BytedanceSeedance25Request value) => new VideoGenerationRequest((global::ElevenLabs.BytedanceSeedance25Request?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.BytedanceSeedance25Request?(VideoGenerationRequest @this) => @this.BytedanceSeedanceV25;

        /// <summary>
        /// 
        /// </summary>
        public VideoGenerationRequest(global::ElevenLabs.BytedanceSeedance25Request? value)
        {
            BytedanceSeedanceV25 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static VideoGenerationRequest FromBytedanceSeedanceV25(global::ElevenLabs.BytedanceSeedance25Request? value) => new VideoGenerationRequest(value);

        /// <summary>
        /// 
        /// </summary>
        public VideoGenerationRequest(
            global::ElevenLabs.VideoGenerationRequestDiscriminatorModelId? modelId,
            global::ElevenLabs.CreatifyAuroraRequest? creatifyAurora,
            global::ElevenLabs.Veo31Request? veo31Generate001,
            global::ElevenLabs.Veo31FastRequest? veo31FastGenerate001,
            global::ElevenLabs.BytedanceSeedance2Request? bytedanceSeedanceV2,
            global::ElevenLabs.BytedanceSeedance2FastRequest? bytedanceSeedanceV2Fast,
            global::ElevenLabs.BytedanceSeedance2MiniRequest? bytedanceSeedanceV2Mini,
            global::ElevenLabs.BytedanceSeedance25Request? bytedanceSeedanceV25
            )
        {
            ModelId = modelId;

            CreatifyAurora = creatifyAurora;
            Veo31Generate001 = veo31Generate001;
            Veo31FastGenerate001 = veo31FastGenerate001;
            BytedanceSeedanceV2 = bytedanceSeedanceV2;
            BytedanceSeedanceV2Fast = bytedanceSeedanceV2Fast;
            BytedanceSeedanceV2Mini = bytedanceSeedanceV2Mini;
            BytedanceSeedanceV25 = bytedanceSeedanceV25;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            BytedanceSeedanceV25 as object ??
            BytedanceSeedanceV2Mini as object ??
            BytedanceSeedanceV2Fast as object ??
            BytedanceSeedanceV2 as object ??
            Veo31FastGenerate001 as object ??
            Veo31Generate001 as object ??
            CreatifyAurora as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            CreatifyAurora?.ToString() ??
            Veo31Generate001?.ToString() ??
            Veo31FastGenerate001?.ToString() ??
            BytedanceSeedanceV2?.ToString() ??
            BytedanceSeedanceV2Fast?.ToString() ??
            BytedanceSeedanceV2Mini?.ToString() ??
            BytedanceSeedanceV25?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsCreatifyAurora && !IsVeo31Generate001 && !IsVeo31FastGenerate001 && !IsBytedanceSeedanceV2 && !IsBytedanceSeedanceV2Fast && !IsBytedanceSeedanceV2Mini && !IsBytedanceSeedanceV25 || !IsCreatifyAurora && IsVeo31Generate001 && !IsVeo31FastGenerate001 && !IsBytedanceSeedanceV2 && !IsBytedanceSeedanceV2Fast && !IsBytedanceSeedanceV2Mini && !IsBytedanceSeedanceV25 || !IsCreatifyAurora && !IsVeo31Generate001 && IsVeo31FastGenerate001 && !IsBytedanceSeedanceV2 && !IsBytedanceSeedanceV2Fast && !IsBytedanceSeedanceV2Mini && !IsBytedanceSeedanceV25 || !IsCreatifyAurora && !IsVeo31Generate001 && !IsVeo31FastGenerate001 && IsBytedanceSeedanceV2 && !IsBytedanceSeedanceV2Fast && !IsBytedanceSeedanceV2Mini && !IsBytedanceSeedanceV25 || !IsCreatifyAurora && !IsVeo31Generate001 && !IsVeo31FastGenerate001 && !IsBytedanceSeedanceV2 && IsBytedanceSeedanceV2Fast && !IsBytedanceSeedanceV2Mini && !IsBytedanceSeedanceV25 || !IsCreatifyAurora && !IsVeo31Generate001 && !IsVeo31FastGenerate001 && !IsBytedanceSeedanceV2 && !IsBytedanceSeedanceV2Fast && IsBytedanceSeedanceV2Mini && !IsBytedanceSeedanceV25 || !IsCreatifyAurora && !IsVeo31Generate001 && !IsVeo31FastGenerate001 && !IsBytedanceSeedanceV2 && !IsBytedanceSeedanceV2Fast && !IsBytedanceSeedanceV2Mini && IsBytedanceSeedanceV25;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::ElevenLabs.CreatifyAuroraRequest, TResult>? creatifyAurora = null,
            global::System.Func<global::ElevenLabs.Veo31Request, TResult>? veo31Generate001 = null,
            global::System.Func<global::ElevenLabs.Veo31FastRequest, TResult>? veo31FastGenerate001 = null,
            global::System.Func<global::ElevenLabs.BytedanceSeedance2Request, TResult>? bytedanceSeedanceV2 = null,
            global::System.Func<global::ElevenLabs.BytedanceSeedance2FastRequest, TResult>? bytedanceSeedanceV2Fast = null,
            global::System.Func<global::ElevenLabs.BytedanceSeedance2MiniRequest, TResult>? bytedanceSeedanceV2Mini = null,
            global::System.Func<global::ElevenLabs.BytedanceSeedance25Request, TResult>? bytedanceSeedanceV25 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCreatifyAurora && creatifyAurora != null)
            {
                return creatifyAurora(CreatifyAurora!);
            }
            else if (IsVeo31Generate001 && veo31Generate001 != null)
            {
                return veo31Generate001(Veo31Generate001!);
            }
            else if (IsVeo31FastGenerate001 && veo31FastGenerate001 != null)
            {
                return veo31FastGenerate001(Veo31FastGenerate001!);
            }
            else if (IsBytedanceSeedanceV2 && bytedanceSeedanceV2 != null)
            {
                return bytedanceSeedanceV2(BytedanceSeedanceV2!);
            }
            else if (IsBytedanceSeedanceV2Fast && bytedanceSeedanceV2Fast != null)
            {
                return bytedanceSeedanceV2Fast(BytedanceSeedanceV2Fast!);
            }
            else if (IsBytedanceSeedanceV2Mini && bytedanceSeedanceV2Mini != null)
            {
                return bytedanceSeedanceV2Mini(BytedanceSeedanceV2Mini!);
            }
            else if (IsBytedanceSeedanceV25 && bytedanceSeedanceV25 != null)
            {
                return bytedanceSeedanceV25(BytedanceSeedanceV25!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::ElevenLabs.CreatifyAuroraRequest>? creatifyAurora = null,

            global::System.Action<global::ElevenLabs.Veo31Request>? veo31Generate001 = null,

            global::System.Action<global::ElevenLabs.Veo31FastRequest>? veo31FastGenerate001 = null,

            global::System.Action<global::ElevenLabs.BytedanceSeedance2Request>? bytedanceSeedanceV2 = null,

            global::System.Action<global::ElevenLabs.BytedanceSeedance2FastRequest>? bytedanceSeedanceV2Fast = null,

            global::System.Action<global::ElevenLabs.BytedanceSeedance2MiniRequest>? bytedanceSeedanceV2Mini = null,

            global::System.Action<global::ElevenLabs.BytedanceSeedance25Request>? bytedanceSeedanceV25 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCreatifyAurora)
            {
                creatifyAurora?.Invoke(CreatifyAurora!);
            }
            else if (IsVeo31Generate001)
            {
                veo31Generate001?.Invoke(Veo31Generate001!);
            }
            else if (IsVeo31FastGenerate001)
            {
                veo31FastGenerate001?.Invoke(Veo31FastGenerate001!);
            }
            else if (IsBytedanceSeedanceV2)
            {
                bytedanceSeedanceV2?.Invoke(BytedanceSeedanceV2!);
            }
            else if (IsBytedanceSeedanceV2Fast)
            {
                bytedanceSeedanceV2Fast?.Invoke(BytedanceSeedanceV2Fast!);
            }
            else if (IsBytedanceSeedanceV2Mini)
            {
                bytedanceSeedanceV2Mini?.Invoke(BytedanceSeedanceV2Mini!);
            }
            else if (IsBytedanceSeedanceV25)
            {
                bytedanceSeedanceV25?.Invoke(BytedanceSeedanceV25!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::ElevenLabs.CreatifyAuroraRequest>? creatifyAurora = null,
            global::System.Action<global::ElevenLabs.Veo31Request>? veo31Generate001 = null,
            global::System.Action<global::ElevenLabs.Veo31FastRequest>? veo31FastGenerate001 = null,
            global::System.Action<global::ElevenLabs.BytedanceSeedance2Request>? bytedanceSeedanceV2 = null,
            global::System.Action<global::ElevenLabs.BytedanceSeedance2FastRequest>? bytedanceSeedanceV2Fast = null,
            global::System.Action<global::ElevenLabs.BytedanceSeedance2MiniRequest>? bytedanceSeedanceV2Mini = null,
            global::System.Action<global::ElevenLabs.BytedanceSeedance25Request>? bytedanceSeedanceV25 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCreatifyAurora)
            {
                creatifyAurora?.Invoke(CreatifyAurora!);
            }
            else if (IsVeo31Generate001)
            {
                veo31Generate001?.Invoke(Veo31Generate001!);
            }
            else if (IsVeo31FastGenerate001)
            {
                veo31FastGenerate001?.Invoke(Veo31FastGenerate001!);
            }
            else if (IsBytedanceSeedanceV2)
            {
                bytedanceSeedanceV2?.Invoke(BytedanceSeedanceV2!);
            }
            else if (IsBytedanceSeedanceV2Fast)
            {
                bytedanceSeedanceV2Fast?.Invoke(BytedanceSeedanceV2Fast!);
            }
            else if (IsBytedanceSeedanceV2Mini)
            {
                bytedanceSeedanceV2Mini?.Invoke(BytedanceSeedanceV2Mini!);
            }
            else if (IsBytedanceSeedanceV25)
            {
                bytedanceSeedanceV25?.Invoke(BytedanceSeedanceV25!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                CreatifyAurora,
                typeof(global::ElevenLabs.CreatifyAuroraRequest),
                Veo31Generate001,
                typeof(global::ElevenLabs.Veo31Request),
                Veo31FastGenerate001,
                typeof(global::ElevenLabs.Veo31FastRequest),
                BytedanceSeedanceV2,
                typeof(global::ElevenLabs.BytedanceSeedance2Request),
                BytedanceSeedanceV2Fast,
                typeof(global::ElevenLabs.BytedanceSeedance2FastRequest),
                BytedanceSeedanceV2Mini,
                typeof(global::ElevenLabs.BytedanceSeedance2MiniRequest),
                BytedanceSeedanceV25,
                typeof(global::ElevenLabs.BytedanceSeedance25Request),
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
        public bool Equals(VideoGenerationRequest other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.CreatifyAuroraRequest?>.Default.Equals(CreatifyAurora, other.CreatifyAurora) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.Veo31Request?>.Default.Equals(Veo31Generate001, other.Veo31Generate001) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.Veo31FastRequest?>.Default.Equals(Veo31FastGenerate001, other.Veo31FastGenerate001) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.BytedanceSeedance2Request?>.Default.Equals(BytedanceSeedanceV2, other.BytedanceSeedanceV2) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.BytedanceSeedance2FastRequest?>.Default.Equals(BytedanceSeedanceV2Fast, other.BytedanceSeedanceV2Fast) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.BytedanceSeedance2MiniRequest?>.Default.Equals(BytedanceSeedanceV2Mini, other.BytedanceSeedanceV2Mini) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.BytedanceSeedance25Request?>.Default.Equals(BytedanceSeedanceV25, other.BytedanceSeedanceV25) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(VideoGenerationRequest obj1, VideoGenerationRequest obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<VideoGenerationRequest>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(VideoGenerationRequest obj1, VideoGenerationRequest obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is VideoGenerationRequest o && Equals(o);
        }
    }
}
