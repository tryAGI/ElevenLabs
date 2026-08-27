#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct ImageGenerationRequest : global::System.IEquatable<ImageGenerationRequest>
    {
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ImageGenerationRequestDiscriminatorModelId? ModelId { get; }

        /// <summary>
        /// Request body for the OpenAI GPT Image 1 model.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.GPTImage1Request? GptImage1 { get; init; }
#else
        public global::ElevenLabs.GPTImage1Request? GptImage1 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GptImage1))]
#endif
        public bool IsGptImage1 => GptImage1 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickGptImage1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.GPTImage1Request? value)
        {
            value = GptImage1;
            return IsGptImage1;
        }

        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GPTImage1Request PickGptImage1() => IsGptImage1
            ? GptImage1!
            : throw new global::System.InvalidOperationException($"Expected union variant 'GptImage1' but the value was {ToString()}.");

        /// <summary>
        /// Request body for the OpenAI GPT Image 1.5 model.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.GPTImage15Request? GptImage15 { get; init; }
#else
        public global::ElevenLabs.GPTImage15Request? GptImage15 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GptImage15))]
#endif
        public bool IsGptImage15 => GptImage15 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickGptImage15(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.GPTImage15Request? value)
        {
            value = GptImage15;
            return IsGptImage15;
        }

        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GPTImage15Request PickGptImage15() => IsGptImage15
            ? GptImage15!
            : throw new global::System.InvalidOperationException($"Expected union variant 'GptImage15' but the value was {ToString()}.");

        /// <summary>
        /// Request body for the OpenAI GPT Image 2 model.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.GPTImage2Request? GptImage2 { get; init; }
#else
        public global::ElevenLabs.GPTImage2Request? GptImage2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GptImage2))]
#endif
        public bool IsGptImage2 => GptImage2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickGptImage2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.GPTImage2Request? value)
        {
            value = GptImage2;
            return IsGptImage2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GPTImage2Request PickGptImage2() => IsGptImage2
            ? GptImage2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'GptImage2' but the value was {ToString()}.");

        /// <summary>
        /// Request body for the Google Gemini 2.5 Flash image model.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.Gemini25FlashImageRequest? Gemini25FlashImage { get; init; }
#else
        public global::ElevenLabs.Gemini25FlashImageRequest? Gemini25FlashImage { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Gemini25FlashImage))]
#endif
        public bool IsGemini25FlashImage => Gemini25FlashImage != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickGemini25FlashImage(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.Gemini25FlashImageRequest? value)
        {
            value = Gemini25FlashImage;
            return IsGemini25FlashImage;
        }

        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.Gemini25FlashImageRequest PickGemini25FlashImage() => IsGemini25FlashImage
            ? Gemini25FlashImage!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Gemini25FlashImage' but the value was {ToString()}.");

        /// <summary>
        /// Request body for the Google Gemini 3 Pro image model.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.Gemini3ProImageRequest? Gemini3ProImage { get; init; }
#else
        public global::ElevenLabs.Gemini3ProImageRequest? Gemini3ProImage { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Gemini3ProImage))]
#endif
        public bool IsGemini3ProImage => Gemini3ProImage != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickGemini3ProImage(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.Gemini3ProImageRequest? value)
        {
            value = Gemini3ProImage;
            return IsGemini3ProImage;
        }

        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.Gemini3ProImageRequest PickGemini3ProImage() => IsGemini3ProImage
            ? Gemini3ProImage!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Gemini3ProImage' but the value was {ToString()}.");

        /// <summary>
        /// Request body for the Google Gemini 3.1 Flash image model.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.Gemini31FlashImageRequest? Gemini31FlashImage { get; init; }
#else
        public global::ElevenLabs.Gemini31FlashImageRequest? Gemini31FlashImage { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Gemini31FlashImage))]
#endif
        public bool IsGemini31FlashImage => Gemini31FlashImage != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickGemini31FlashImage(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.Gemini31FlashImageRequest? value)
        {
            value = Gemini31FlashImage;
            return IsGemini31FlashImage;
        }

        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.Gemini31FlashImageRequest PickGemini31FlashImage() => IsGemini31FlashImage
            ? Gemini31FlashImage!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Gemini31FlashImage' but the value was {ToString()}.");

        /// <summary>
        /// Request body for the Google Gemini 3.1 Flash Lite image model.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.Gemini31FlashLiteImageRequest? Gemini31FlashLiteImage { get; init; }
#else
        public global::ElevenLabs.Gemini31FlashLiteImageRequest? Gemini31FlashLiteImage { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Gemini31FlashLiteImage))]
#endif
        public bool IsGemini31FlashLiteImage => Gemini31FlashLiteImage != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickGemini31FlashLiteImage(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.Gemini31FlashLiteImageRequest? value)
        {
            value = Gemini31FlashLiteImage;
            return IsGemini31FlashLiteImage;
        }

        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.Gemini31FlashLiteImageRequest PickGemini31FlashLiteImage() => IsGemini31FlashLiteImage
            ? Gemini31FlashLiteImage!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Gemini31FlashLiteImage' but the value was {ToString()}.");

        /// <summary>
        /// Request body for the ByteDance Seedream 5.0 Lite image model.<br/>
        /// ByteDance models are disabled by default and require explicit approval<br/>
        /// before use. Contact support to request access.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.BytedanceSeedream5LiteRequest? BytedanceSeedream5Lite { get; init; }
#else
        public global::ElevenLabs.BytedanceSeedream5LiteRequest? BytedanceSeedream5Lite { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BytedanceSeedream5Lite))]
#endif
        public bool IsBytedanceSeedream5Lite => BytedanceSeedream5Lite != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickBytedanceSeedream5Lite(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.BytedanceSeedream5LiteRequest? value)
        {
            value = BytedanceSeedream5Lite;
            return IsBytedanceSeedream5Lite;
        }

        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BytedanceSeedream5LiteRequest PickBytedanceSeedream5Lite() => IsBytedanceSeedream5Lite
            ? BytedanceSeedream5Lite!
            : throw new global::System.InvalidOperationException($"Expected union variant 'BytedanceSeedream5Lite' but the value was {ToString()}.");

        /// <summary>
        /// Request body for the ByteDance Seedream 5.0 Pro image model.<br/>
        /// ByteDance models are disabled by default and require explicit approval<br/>
        /// before use. Contact support to request access.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.BytedanceSeedream5ProRequest? BytedanceSeedream5Pro { get; init; }
#else
        public global::ElevenLabs.BytedanceSeedream5ProRequest? BytedanceSeedream5Pro { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BytedanceSeedream5Pro))]
#endif
        public bool IsBytedanceSeedream5Pro => BytedanceSeedream5Pro != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickBytedanceSeedream5Pro(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.BytedanceSeedream5ProRequest? value)
        {
            value = BytedanceSeedream5Pro;
            return IsBytedanceSeedream5Pro;
        }

        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BytedanceSeedream5ProRequest PickBytedanceSeedream5Pro() => IsBytedanceSeedream5Pro
            ? BytedanceSeedream5Pro!
            : throw new global::System.InvalidOperationException($"Expected union variant 'BytedanceSeedream5Pro' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator ImageGenerationRequest(global::ElevenLabs.GPTImage1Request value) => new ImageGenerationRequest((global::ElevenLabs.GPTImage1Request?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::ElevenLabs.GPTImage1Request?(ImageGenerationRequest @this) => @this.GptImage1;

        /// <summary>
        ///
        /// </summary>
        public ImageGenerationRequest(global::ElevenLabs.GPTImage1Request? value)
        {
            GptImage1 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ImageGenerationRequest FromGptImage1(global::ElevenLabs.GPTImage1Request? value) => new ImageGenerationRequest(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ImageGenerationRequest(global::ElevenLabs.GPTImage15Request value) => new ImageGenerationRequest((global::ElevenLabs.GPTImage15Request?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::ElevenLabs.GPTImage15Request?(ImageGenerationRequest @this) => @this.GptImage15;

        /// <summary>
        ///
        /// </summary>
        public ImageGenerationRequest(global::ElevenLabs.GPTImage15Request? value)
        {
            GptImage15 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ImageGenerationRequest FromGptImage15(global::ElevenLabs.GPTImage15Request? value) => new ImageGenerationRequest(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ImageGenerationRequest(global::ElevenLabs.GPTImage2Request value) => new ImageGenerationRequest((global::ElevenLabs.GPTImage2Request?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::ElevenLabs.GPTImage2Request?(ImageGenerationRequest @this) => @this.GptImage2;

        /// <summary>
        ///
        /// </summary>
        public ImageGenerationRequest(global::ElevenLabs.GPTImage2Request? value)
        {
            GptImage2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ImageGenerationRequest FromGptImage2(global::ElevenLabs.GPTImage2Request? value) => new ImageGenerationRequest(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ImageGenerationRequest(global::ElevenLabs.Gemini25FlashImageRequest value) => new ImageGenerationRequest((global::ElevenLabs.Gemini25FlashImageRequest?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::ElevenLabs.Gemini25FlashImageRequest?(ImageGenerationRequest @this) => @this.Gemini25FlashImage;

        /// <summary>
        ///
        /// </summary>
        public ImageGenerationRequest(global::ElevenLabs.Gemini25FlashImageRequest? value)
        {
            Gemini25FlashImage = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ImageGenerationRequest FromGemini25FlashImage(global::ElevenLabs.Gemini25FlashImageRequest? value) => new ImageGenerationRequest(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ImageGenerationRequest(global::ElevenLabs.Gemini3ProImageRequest value) => new ImageGenerationRequest((global::ElevenLabs.Gemini3ProImageRequest?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::ElevenLabs.Gemini3ProImageRequest?(ImageGenerationRequest @this) => @this.Gemini3ProImage;

        /// <summary>
        ///
        /// </summary>
        public ImageGenerationRequest(global::ElevenLabs.Gemini3ProImageRequest? value)
        {
            Gemini3ProImage = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ImageGenerationRequest FromGemini3ProImage(global::ElevenLabs.Gemini3ProImageRequest? value) => new ImageGenerationRequest(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ImageGenerationRequest(global::ElevenLabs.Gemini31FlashImageRequest value) => new ImageGenerationRequest((global::ElevenLabs.Gemini31FlashImageRequest?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::ElevenLabs.Gemini31FlashImageRequest?(ImageGenerationRequest @this) => @this.Gemini31FlashImage;

        /// <summary>
        ///
        /// </summary>
        public ImageGenerationRequest(global::ElevenLabs.Gemini31FlashImageRequest? value)
        {
            Gemini31FlashImage = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ImageGenerationRequest FromGemini31FlashImage(global::ElevenLabs.Gemini31FlashImageRequest? value) => new ImageGenerationRequest(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ImageGenerationRequest(global::ElevenLabs.Gemini31FlashLiteImageRequest value) => new ImageGenerationRequest((global::ElevenLabs.Gemini31FlashLiteImageRequest?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::ElevenLabs.Gemini31FlashLiteImageRequest?(ImageGenerationRequest @this) => @this.Gemini31FlashLiteImage;

        /// <summary>
        ///
        /// </summary>
        public ImageGenerationRequest(global::ElevenLabs.Gemini31FlashLiteImageRequest? value)
        {
            Gemini31FlashLiteImage = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ImageGenerationRequest FromGemini31FlashLiteImage(global::ElevenLabs.Gemini31FlashLiteImageRequest? value) => new ImageGenerationRequest(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ImageGenerationRequest(global::ElevenLabs.BytedanceSeedream5LiteRequest value) => new ImageGenerationRequest((global::ElevenLabs.BytedanceSeedream5LiteRequest?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::ElevenLabs.BytedanceSeedream5LiteRequest?(ImageGenerationRequest @this) => @this.BytedanceSeedream5Lite;

        /// <summary>
        ///
        /// </summary>
        public ImageGenerationRequest(global::ElevenLabs.BytedanceSeedream5LiteRequest? value)
        {
            BytedanceSeedream5Lite = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ImageGenerationRequest FromBytedanceSeedream5Lite(global::ElevenLabs.BytedanceSeedream5LiteRequest? value) => new ImageGenerationRequest(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ImageGenerationRequest(global::ElevenLabs.BytedanceSeedream5ProRequest value) => new ImageGenerationRequest((global::ElevenLabs.BytedanceSeedream5ProRequest?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::ElevenLabs.BytedanceSeedream5ProRequest?(ImageGenerationRequest @this) => @this.BytedanceSeedream5Pro;

        /// <summary>
        ///
        /// </summary>
        public ImageGenerationRequest(global::ElevenLabs.BytedanceSeedream5ProRequest? value)
        {
            BytedanceSeedream5Pro = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ImageGenerationRequest FromBytedanceSeedream5Pro(global::ElevenLabs.BytedanceSeedream5ProRequest? value) => new ImageGenerationRequest(value);

        /// <summary>
        ///
        /// </summary>
        public ImageGenerationRequest(
            global::ElevenLabs.ImageGenerationRequestDiscriminatorModelId? modelId,
            global::ElevenLabs.GPTImage1Request? gptImage1,
            global::ElevenLabs.GPTImage15Request? gptImage15,
            global::ElevenLabs.GPTImage2Request? gptImage2,
            global::ElevenLabs.Gemini25FlashImageRequest? gemini25FlashImage,
            global::ElevenLabs.Gemini3ProImageRequest? gemini3ProImage,
            global::ElevenLabs.Gemini31FlashImageRequest? gemini31FlashImage,
            global::ElevenLabs.Gemini31FlashLiteImageRequest? gemini31FlashLiteImage,
            global::ElevenLabs.BytedanceSeedream5LiteRequest? bytedanceSeedream5Lite,
            global::ElevenLabs.BytedanceSeedream5ProRequest? bytedanceSeedream5Pro
            )
        {
            ModelId = modelId;

            GptImage1 = gptImage1;
            GptImage15 = gptImage15;
            GptImage2 = gptImage2;
            Gemini25FlashImage = gemini25FlashImage;
            Gemini3ProImage = gemini3ProImage;
            Gemini31FlashImage = gemini31FlashImage;
            Gemini31FlashLiteImage = gemini31FlashLiteImage;
            BytedanceSeedream5Lite = bytedanceSeedream5Lite;
            BytedanceSeedream5Pro = bytedanceSeedream5Pro;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            BytedanceSeedream5Pro as object ??
            BytedanceSeedream5Lite as object ??
            Gemini31FlashLiteImage as object ??
            Gemini31FlashImage as object ??
            Gemini3ProImage as object ??
            Gemini25FlashImage as object ??
            GptImage2 as object ??
            GptImage15 as object ??
            GptImage1 as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            GptImage1?.ToString() ??
            GptImage15?.ToString() ??
            GptImage2?.ToString() ??
            Gemini25FlashImage?.ToString() ??
            Gemini3ProImage?.ToString() ??
            Gemini31FlashImage?.ToString() ??
            Gemini31FlashLiteImage?.ToString() ??
            BytedanceSeedream5Lite?.ToString() ??
            BytedanceSeedream5Pro?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsGptImage1 && !IsGptImage15 && !IsGptImage2 && !IsGemini25FlashImage && !IsGemini3ProImage && !IsGemini31FlashImage && !IsGemini31FlashLiteImage && !IsBytedanceSeedream5Lite && !IsBytedanceSeedream5Pro || !IsGptImage1 && IsGptImage15 && !IsGptImage2 && !IsGemini25FlashImage && !IsGemini3ProImage && !IsGemini31FlashImage && !IsGemini31FlashLiteImage && !IsBytedanceSeedream5Lite && !IsBytedanceSeedream5Pro || !IsGptImage1 && !IsGptImage15 && IsGptImage2 && !IsGemini25FlashImage && !IsGemini3ProImage && !IsGemini31FlashImage && !IsGemini31FlashLiteImage && !IsBytedanceSeedream5Lite && !IsBytedanceSeedream5Pro || !IsGptImage1 && !IsGptImage15 && !IsGptImage2 && IsGemini25FlashImage && !IsGemini3ProImage && !IsGemini31FlashImage && !IsGemini31FlashLiteImage && !IsBytedanceSeedream5Lite && !IsBytedanceSeedream5Pro || !IsGptImage1 && !IsGptImage15 && !IsGptImage2 && !IsGemini25FlashImage && IsGemini3ProImage && !IsGemini31FlashImage && !IsGemini31FlashLiteImage && !IsBytedanceSeedream5Lite && !IsBytedanceSeedream5Pro || !IsGptImage1 && !IsGptImage15 && !IsGptImage2 && !IsGemini25FlashImage && !IsGemini3ProImage && IsGemini31FlashImage && !IsGemini31FlashLiteImage && !IsBytedanceSeedream5Lite && !IsBytedanceSeedream5Pro || !IsGptImage1 && !IsGptImage15 && !IsGptImage2 && !IsGemini25FlashImage && !IsGemini3ProImage && !IsGemini31FlashImage && IsGemini31FlashLiteImage && !IsBytedanceSeedream5Lite && !IsBytedanceSeedream5Pro || !IsGptImage1 && !IsGptImage15 && !IsGptImage2 && !IsGemini25FlashImage && !IsGemini3ProImage && !IsGemini31FlashImage && !IsGemini31FlashLiteImage && IsBytedanceSeedream5Lite && !IsBytedanceSeedream5Pro || !IsGptImage1 && !IsGptImage15 && !IsGptImage2 && !IsGemini25FlashImage && !IsGemini3ProImage && !IsGemini31FlashImage && !IsGemini31FlashLiteImage && !IsBytedanceSeedream5Lite && IsBytedanceSeedream5Pro;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::ElevenLabs.GPTImage1Request, TResult>? gptImage1 = null,
            global::System.Func<global::ElevenLabs.GPTImage15Request, TResult>? gptImage15 = null,
            global::System.Func<global::ElevenLabs.GPTImage2Request, TResult>? gptImage2 = null,
            global::System.Func<global::ElevenLabs.Gemini25FlashImageRequest, TResult>? gemini25FlashImage = null,
            global::System.Func<global::ElevenLabs.Gemini3ProImageRequest, TResult>? gemini3ProImage = null,
            global::System.Func<global::ElevenLabs.Gemini31FlashImageRequest, TResult>? gemini31FlashImage = null,
            global::System.Func<global::ElevenLabs.Gemini31FlashLiteImageRequest, TResult>? gemini31FlashLiteImage = null,
            global::System.Func<global::ElevenLabs.BytedanceSeedream5LiteRequest, TResult>? bytedanceSeedream5Lite = null,
            global::System.Func<global::ElevenLabs.BytedanceSeedream5ProRequest, TResult>? bytedanceSeedream5Pro = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsGptImage1 && gptImage1 != null)
            {
                return gptImage1(GptImage1!);
            }
            else if (IsGptImage15 && gptImage15 != null)
            {
                return gptImage15(GptImage15!);
            }
            else if (IsGptImage2 && gptImage2 != null)
            {
                return gptImage2(GptImage2!);
            }
            else if (IsGemini25FlashImage && gemini25FlashImage != null)
            {
                return gemini25FlashImage(Gemini25FlashImage!);
            }
            else if (IsGemini3ProImage && gemini3ProImage != null)
            {
                return gemini3ProImage(Gemini3ProImage!);
            }
            else if (IsGemini31FlashImage && gemini31FlashImage != null)
            {
                return gemini31FlashImage(Gemini31FlashImage!);
            }
            else if (IsGemini31FlashLiteImage && gemini31FlashLiteImage != null)
            {
                return gemini31FlashLiteImage(Gemini31FlashLiteImage!);
            }
            else if (IsBytedanceSeedream5Lite && bytedanceSeedream5Lite != null)
            {
                return bytedanceSeedream5Lite(BytedanceSeedream5Lite!);
            }
            else if (IsBytedanceSeedream5Pro && bytedanceSeedream5Pro != null)
            {
                return bytedanceSeedream5Pro(BytedanceSeedream5Pro!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::ElevenLabs.GPTImage1Request>? gptImage1 = null,

            global::System.Action<global::ElevenLabs.GPTImage15Request>? gptImage15 = null,

            global::System.Action<global::ElevenLabs.GPTImage2Request>? gptImage2 = null,

            global::System.Action<global::ElevenLabs.Gemini25FlashImageRequest>? gemini25FlashImage = null,

            global::System.Action<global::ElevenLabs.Gemini3ProImageRequest>? gemini3ProImage = null,

            global::System.Action<global::ElevenLabs.Gemini31FlashImageRequest>? gemini31FlashImage = null,

            global::System.Action<global::ElevenLabs.Gemini31FlashLiteImageRequest>? gemini31FlashLiteImage = null,

            global::System.Action<global::ElevenLabs.BytedanceSeedream5LiteRequest>? bytedanceSeedream5Lite = null,

            global::System.Action<global::ElevenLabs.BytedanceSeedream5ProRequest>? bytedanceSeedream5Pro = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsGptImage1)
            {
                gptImage1?.Invoke(GptImage1!);
            }
            else if (IsGptImage15)
            {
                gptImage15?.Invoke(GptImage15!);
            }
            else if (IsGptImage2)
            {
                gptImage2?.Invoke(GptImage2!);
            }
            else if (IsGemini25FlashImage)
            {
                gemini25FlashImage?.Invoke(Gemini25FlashImage!);
            }
            else if (IsGemini3ProImage)
            {
                gemini3ProImage?.Invoke(Gemini3ProImage!);
            }
            else if (IsGemini31FlashImage)
            {
                gemini31FlashImage?.Invoke(Gemini31FlashImage!);
            }
            else if (IsGemini31FlashLiteImage)
            {
                gemini31FlashLiteImage?.Invoke(Gemini31FlashLiteImage!);
            }
            else if (IsBytedanceSeedream5Lite)
            {
                bytedanceSeedream5Lite?.Invoke(BytedanceSeedream5Lite!);
            }
            else if (IsBytedanceSeedream5Pro)
            {
                bytedanceSeedream5Pro?.Invoke(BytedanceSeedream5Pro!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::ElevenLabs.GPTImage1Request>? gptImage1 = null,
            global::System.Action<global::ElevenLabs.GPTImage15Request>? gptImage15 = null,
            global::System.Action<global::ElevenLabs.GPTImage2Request>? gptImage2 = null,
            global::System.Action<global::ElevenLabs.Gemini25FlashImageRequest>? gemini25FlashImage = null,
            global::System.Action<global::ElevenLabs.Gemini3ProImageRequest>? gemini3ProImage = null,
            global::System.Action<global::ElevenLabs.Gemini31FlashImageRequest>? gemini31FlashImage = null,
            global::System.Action<global::ElevenLabs.Gemini31FlashLiteImageRequest>? gemini31FlashLiteImage = null,
            global::System.Action<global::ElevenLabs.BytedanceSeedream5LiteRequest>? bytedanceSeedream5Lite = null,
            global::System.Action<global::ElevenLabs.BytedanceSeedream5ProRequest>? bytedanceSeedream5Pro = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsGptImage1)
            {
                gptImage1?.Invoke(GptImage1!);
            }
            else if (IsGptImage15)
            {
                gptImage15?.Invoke(GptImage15!);
            }
            else if (IsGptImage2)
            {
                gptImage2?.Invoke(GptImage2!);
            }
            else if (IsGemini25FlashImage)
            {
                gemini25FlashImage?.Invoke(Gemini25FlashImage!);
            }
            else if (IsGemini3ProImage)
            {
                gemini3ProImage?.Invoke(Gemini3ProImage!);
            }
            else if (IsGemini31FlashImage)
            {
                gemini31FlashImage?.Invoke(Gemini31FlashImage!);
            }
            else if (IsGemini31FlashLiteImage)
            {
                gemini31FlashLiteImage?.Invoke(Gemini31FlashLiteImage!);
            }
            else if (IsBytedanceSeedream5Lite)
            {
                bytedanceSeedream5Lite?.Invoke(BytedanceSeedream5Lite!);
            }
            else if (IsBytedanceSeedream5Pro)
            {
                bytedanceSeedream5Pro?.Invoke(BytedanceSeedream5Pro!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                GptImage1,
                typeof(global::ElevenLabs.GPTImage1Request),
                GptImage15,
                typeof(global::ElevenLabs.GPTImage15Request),
                GptImage2,
                typeof(global::ElevenLabs.GPTImage2Request),
                Gemini25FlashImage,
                typeof(global::ElevenLabs.Gemini25FlashImageRequest),
                Gemini3ProImage,
                typeof(global::ElevenLabs.Gemini3ProImageRequest),
                Gemini31FlashImage,
                typeof(global::ElevenLabs.Gemini31FlashImageRequest),
                Gemini31FlashLiteImage,
                typeof(global::ElevenLabs.Gemini31FlashLiteImageRequest),
                BytedanceSeedream5Lite,
                typeof(global::ElevenLabs.BytedanceSeedream5LiteRequest),
                BytedanceSeedream5Pro,
                typeof(global::ElevenLabs.BytedanceSeedream5ProRequest),
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
        public bool Equals(ImageGenerationRequest other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.GPTImage1Request?>.Default.Equals(GptImage1, other.GptImage1) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.GPTImage15Request?>.Default.Equals(GptImage15, other.GptImage15) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.GPTImage2Request?>.Default.Equals(GptImage2, other.GptImage2) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.Gemini25FlashImageRequest?>.Default.Equals(Gemini25FlashImage, other.Gemini25FlashImage) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.Gemini3ProImageRequest?>.Default.Equals(Gemini3ProImage, other.Gemini3ProImage) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.Gemini31FlashImageRequest?>.Default.Equals(Gemini31FlashImage, other.Gemini31FlashImage) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.Gemini31FlashLiteImageRequest?>.Default.Equals(Gemini31FlashLiteImage, other.Gemini31FlashLiteImage) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.BytedanceSeedream5LiteRequest?>.Default.Equals(BytedanceSeedream5Lite, other.BytedanceSeedream5Lite) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.BytedanceSeedream5ProRequest?>.Default.Equals(BytedanceSeedream5Pro, other.BytedanceSeedream5Pro)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(ImageGenerationRequest obj1, ImageGenerationRequest obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ImageGenerationRequest>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ImageGenerationRequest obj1, ImageGenerationRequest obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ImageGenerationRequest o && Equals(o);
        }
    }
}
