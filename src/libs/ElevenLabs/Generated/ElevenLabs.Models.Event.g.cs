#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct Event : global::System.IEquatable<Event>
    {
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.StreamEnvelopeEventDiscriminatorType? Type { get; }

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.StreamEndedEvent? StreamEnded { get; init; }
#else
        public global::ElevenLabs.StreamEndedEvent? StreamEnded { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StreamEnded))]
#endif
        public bool IsStreamEnded => StreamEnded != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStreamEnded(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.StreamEndedEvent? value)
        {
            value = StreamEnded;
            return IsStreamEnded;
        }

        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.StreamEndedEvent PickStreamEnded() => StreamEnded is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StreamEnded' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.AgentChatResponsePartClientEvent? AgentChatResponsePart { get; init; }
#else
        public global::ElevenLabs.AgentChatResponsePartClientEvent? AgentChatResponsePart { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AgentChatResponsePart))]
#endif
        public bool IsAgentChatResponsePart => AgentChatResponsePart != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAgentChatResponsePart(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.AgentChatResponsePartClientEvent? value)
        {
            value = AgentChatResponsePart;
            return IsAgentChatResponsePart;
        }

        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentChatResponsePartClientEvent PickAgentChatResponsePart() => AgentChatResponsePart is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'AgentChatResponsePart' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.AgentReasoningResponsePartClientEvent? AgentReasoningResponsePart { get; init; }
#else
        public global::ElevenLabs.AgentReasoningResponsePartClientEvent? AgentReasoningResponsePart { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AgentReasoningResponsePart))]
#endif
        public bool IsAgentReasoningResponsePart => AgentReasoningResponsePart != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAgentReasoningResponsePart(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.AgentReasoningResponsePartClientEvent? value)
        {
            value = AgentReasoningResponsePart;
            return IsAgentReasoningResponsePart;
        }

        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentReasoningResponsePartClientEvent PickAgentReasoningResponsePart() => AgentReasoningResponsePart is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'AgentReasoningResponsePart' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.AgentResponseClientEvent? AgentResponse { get; init; }
#else
        public global::ElevenLabs.AgentResponseClientEvent? AgentResponse { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AgentResponse))]
#endif
        public bool IsAgentResponse => AgentResponse != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAgentResponse(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.AgentResponseClientEvent? value)
        {
            value = AgentResponse;
            return IsAgentResponse;
        }

        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentResponseClientEvent PickAgentResponse() => AgentResponse is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'AgentResponse' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.AgentToolRequestStreamedEvent? AgentToolRequest { get; init; }
#else
        public global::ElevenLabs.AgentToolRequestStreamedEvent? AgentToolRequest { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AgentToolRequest))]
#endif
        public bool IsAgentToolRequest => AgentToolRequest != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAgentToolRequest(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.AgentToolRequestStreamedEvent? value)
        {
            value = AgentToolRequest;
            return IsAgentToolRequest;
        }

        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentToolRequestStreamedEvent PickAgentToolRequest() => AgentToolRequest is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'AgentToolRequest' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.AgentToolResponseStreamedEvent? AgentToolResponse { get; init; }
#else
        public global::ElevenLabs.AgentToolResponseStreamedEvent? AgentToolResponse { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AgentToolResponse))]
#endif
        public bool IsAgentToolResponse => AgentToolResponse != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAgentToolResponse(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.AgentToolResponseStreamedEvent? value)
        {
            value = AgentToolResponse;
            return IsAgentToolResponse;
        }

        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AgentToolResponseStreamedEvent PickAgentToolResponse() => AgentToolResponse is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'AgentToolResponse' but the value was {ToString()}.");

        /// <summary>
        /// `ClientToolCallClientEvent` as a stream event, because its custom `__init__` can't parse its own JSON.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.ClientToolCallEvent? ClientToolCall { get; init; }
#else
        public global::ElevenLabs.ClientToolCallEvent? ClientToolCall { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ClientToolCall))]
#endif
        public bool IsClientToolCall => ClientToolCall != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickClientToolCall(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.ClientToolCallEvent? value)
        {
            value = ClientToolCall;
            return IsClientToolCall;
        }

        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ClientToolCallEvent PickClientToolCall() => ClientToolCall is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ClientToolCall' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator Event(global::ElevenLabs.StreamEndedEvent value) => new Event((global::ElevenLabs.StreamEndedEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::ElevenLabs.StreamEndedEvent?(Event @this) => @this.StreamEnded;

        /// <summary>
        ///
        /// </summary>
        public Event(global::ElevenLabs.StreamEndedEvent? value)
        {
            StreamEnded = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Event FromStreamEnded(global::ElevenLabs.StreamEndedEvent? value) => new Event(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Event(global::ElevenLabs.AgentChatResponsePartClientEvent value) => new Event((global::ElevenLabs.AgentChatResponsePartClientEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::ElevenLabs.AgentChatResponsePartClientEvent?(Event @this) => @this.AgentChatResponsePart;

        /// <summary>
        ///
        /// </summary>
        public Event(global::ElevenLabs.AgentChatResponsePartClientEvent? value)
        {
            AgentChatResponsePart = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Event FromAgentChatResponsePart(global::ElevenLabs.AgentChatResponsePartClientEvent? value) => new Event(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Event(global::ElevenLabs.AgentReasoningResponsePartClientEvent value) => new Event((global::ElevenLabs.AgentReasoningResponsePartClientEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::ElevenLabs.AgentReasoningResponsePartClientEvent?(Event @this) => @this.AgentReasoningResponsePart;

        /// <summary>
        ///
        /// </summary>
        public Event(global::ElevenLabs.AgentReasoningResponsePartClientEvent? value)
        {
            AgentReasoningResponsePart = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Event FromAgentReasoningResponsePart(global::ElevenLabs.AgentReasoningResponsePartClientEvent? value) => new Event(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Event(global::ElevenLabs.AgentResponseClientEvent value) => new Event((global::ElevenLabs.AgentResponseClientEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::ElevenLabs.AgentResponseClientEvent?(Event @this) => @this.AgentResponse;

        /// <summary>
        ///
        /// </summary>
        public Event(global::ElevenLabs.AgentResponseClientEvent? value)
        {
            AgentResponse = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Event FromAgentResponse(global::ElevenLabs.AgentResponseClientEvent? value) => new Event(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Event(global::ElevenLabs.AgentToolRequestStreamedEvent value) => new Event((global::ElevenLabs.AgentToolRequestStreamedEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::ElevenLabs.AgentToolRequestStreamedEvent?(Event @this) => @this.AgentToolRequest;

        /// <summary>
        ///
        /// </summary>
        public Event(global::ElevenLabs.AgentToolRequestStreamedEvent? value)
        {
            AgentToolRequest = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Event FromAgentToolRequest(global::ElevenLabs.AgentToolRequestStreamedEvent? value) => new Event(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Event(global::ElevenLabs.AgentToolResponseStreamedEvent value) => new Event((global::ElevenLabs.AgentToolResponseStreamedEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::ElevenLabs.AgentToolResponseStreamedEvent?(Event @this) => @this.AgentToolResponse;

        /// <summary>
        ///
        /// </summary>
        public Event(global::ElevenLabs.AgentToolResponseStreamedEvent? value)
        {
            AgentToolResponse = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Event FromAgentToolResponse(global::ElevenLabs.AgentToolResponseStreamedEvent? value) => new Event(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Event(global::ElevenLabs.ClientToolCallEvent value) => new Event((global::ElevenLabs.ClientToolCallEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::ElevenLabs.ClientToolCallEvent?(Event @this) => @this.ClientToolCall;

        /// <summary>
        ///
        /// </summary>
        public Event(global::ElevenLabs.ClientToolCallEvent? value)
        {
            ClientToolCall = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Event FromClientToolCall(global::ElevenLabs.ClientToolCallEvent? value) => new Event(value);

        /// <summary>
        ///
        /// </summary>
        public Event(
            global::ElevenLabs.StreamEnvelopeEventDiscriminatorType? type,
            global::ElevenLabs.StreamEndedEvent? streamEnded,
            global::ElevenLabs.AgentChatResponsePartClientEvent? agentChatResponsePart,
            global::ElevenLabs.AgentReasoningResponsePartClientEvent? agentReasoningResponsePart,
            global::ElevenLabs.AgentResponseClientEvent? agentResponse,
            global::ElevenLabs.AgentToolRequestStreamedEvent? agentToolRequest,
            global::ElevenLabs.AgentToolResponseStreamedEvent? agentToolResponse,
            global::ElevenLabs.ClientToolCallEvent? clientToolCall
            )
        {
            Type = type;

            StreamEnded = streamEnded;
            AgentChatResponsePart = agentChatResponsePart;
            AgentReasoningResponsePart = agentReasoningResponsePart;
            AgentResponse = agentResponse;
            AgentToolRequest = agentToolRequest;
            AgentToolResponse = agentToolResponse;
            ClientToolCall = clientToolCall;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            ClientToolCall as object ??
            AgentToolResponse as object ??
            AgentToolRequest as object ??
            AgentResponse as object ??
            AgentReasoningResponsePart as object ??
            AgentChatResponsePart as object ??
            StreamEnded as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            StreamEnded?.ToString() ??
            AgentChatResponsePart?.ToString() ??
            AgentReasoningResponsePart?.ToString() ??
            AgentResponse?.ToString() ??
            AgentToolRequest?.ToString() ??
            AgentToolResponse?.ToString() ??
            ClientToolCall?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsStreamEnded && !IsAgentChatResponsePart && !IsAgentReasoningResponsePart && !IsAgentResponse && !IsAgentToolRequest && !IsAgentToolResponse && !IsClientToolCall || !IsStreamEnded && IsAgentChatResponsePart && !IsAgentReasoningResponsePart && !IsAgentResponse && !IsAgentToolRequest && !IsAgentToolResponse && !IsClientToolCall || !IsStreamEnded && !IsAgentChatResponsePart && IsAgentReasoningResponsePart && !IsAgentResponse && !IsAgentToolRequest && !IsAgentToolResponse && !IsClientToolCall || !IsStreamEnded && !IsAgentChatResponsePart && !IsAgentReasoningResponsePart && IsAgentResponse && !IsAgentToolRequest && !IsAgentToolResponse && !IsClientToolCall || !IsStreamEnded && !IsAgentChatResponsePart && !IsAgentReasoningResponsePart && !IsAgentResponse && IsAgentToolRequest && !IsAgentToolResponse && !IsClientToolCall || !IsStreamEnded && !IsAgentChatResponsePart && !IsAgentReasoningResponsePart && !IsAgentResponse && !IsAgentToolRequest && IsAgentToolResponse && !IsClientToolCall || !IsStreamEnded && !IsAgentChatResponsePart && !IsAgentReasoningResponsePart && !IsAgentResponse && !IsAgentToolRequest && !IsAgentToolResponse && IsClientToolCall;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::ElevenLabs.StreamEndedEvent, TResult>? streamEnded = null,
            global::System.Func<global::ElevenLabs.AgentChatResponsePartClientEvent, TResult>? agentChatResponsePart = null,
            global::System.Func<global::ElevenLabs.AgentReasoningResponsePartClientEvent, TResult>? agentReasoningResponsePart = null,
            global::System.Func<global::ElevenLabs.AgentResponseClientEvent, TResult>? agentResponse = null,
            global::System.Func<global::ElevenLabs.AgentToolRequestStreamedEvent, TResult>? agentToolRequest = null,
            global::System.Func<global::ElevenLabs.AgentToolResponseStreamedEvent, TResult>? agentToolResponse = null,
            global::System.Func<global::ElevenLabs.ClientToolCallEvent, TResult>? clientToolCall = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (StreamEnded is { } __value0 && streamEnded != null)
            {
                return streamEnded(__value0);
            }
            else if (AgentChatResponsePart is { } __value1 && agentChatResponsePart != null)
            {
                return agentChatResponsePart(__value1);
            }
            else if (AgentReasoningResponsePart is { } __value2 && agentReasoningResponsePart != null)
            {
                return agentReasoningResponsePart(__value2);
            }
            else if (AgentResponse is { } __value3 && agentResponse != null)
            {
                return agentResponse(__value3);
            }
            else if (AgentToolRequest is { } __value4 && agentToolRequest != null)
            {
                return agentToolRequest(__value4);
            }
            else if (AgentToolResponse is { } __value5 && agentToolResponse != null)
            {
                return agentToolResponse(__value5);
            }
            else if (ClientToolCall is { } __value6 && clientToolCall != null)
            {
                return clientToolCall(__value6);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::ElevenLabs.StreamEndedEvent>? streamEnded = null,

            global::System.Action<global::ElevenLabs.AgentChatResponsePartClientEvent>? agentChatResponsePart = null,

            global::System.Action<global::ElevenLabs.AgentReasoningResponsePartClientEvent>? agentReasoningResponsePart = null,

            global::System.Action<global::ElevenLabs.AgentResponseClientEvent>? agentResponse = null,

            global::System.Action<global::ElevenLabs.AgentToolRequestStreamedEvent>? agentToolRequest = null,

            global::System.Action<global::ElevenLabs.AgentToolResponseStreamedEvent>? agentToolResponse = null,

            global::System.Action<global::ElevenLabs.ClientToolCallEvent>? clientToolCall = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (StreamEnded is { } __value0)
            {
                streamEnded?.Invoke(__value0);
            }
            else if (AgentChatResponsePart is { } __value1)
            {
                agentChatResponsePart?.Invoke(__value1);
            }
            else if (AgentReasoningResponsePart is { } __value2)
            {
                agentReasoningResponsePart?.Invoke(__value2);
            }
            else if (AgentResponse is { } __value3)
            {
                agentResponse?.Invoke(__value3);
            }
            else if (AgentToolRequest is { } __value4)
            {
                agentToolRequest?.Invoke(__value4);
            }
            else if (AgentToolResponse is { } __value5)
            {
                agentToolResponse?.Invoke(__value5);
            }
            else if (ClientToolCall is { } __value6)
            {
                clientToolCall?.Invoke(__value6);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::ElevenLabs.StreamEndedEvent>? streamEnded = null,
            global::System.Action<global::ElevenLabs.AgentChatResponsePartClientEvent>? agentChatResponsePart = null,
            global::System.Action<global::ElevenLabs.AgentReasoningResponsePartClientEvent>? agentReasoningResponsePart = null,
            global::System.Action<global::ElevenLabs.AgentResponseClientEvent>? agentResponse = null,
            global::System.Action<global::ElevenLabs.AgentToolRequestStreamedEvent>? agentToolRequest = null,
            global::System.Action<global::ElevenLabs.AgentToolResponseStreamedEvent>? agentToolResponse = null,
            global::System.Action<global::ElevenLabs.ClientToolCallEvent>? clientToolCall = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (StreamEnded is { } __value0)
            {
                streamEnded?.Invoke(__value0);
            }
            else if (AgentChatResponsePart is { } __value1)
            {
                agentChatResponsePart?.Invoke(__value1);
            }
            else if (AgentReasoningResponsePart is { } __value2)
            {
                agentReasoningResponsePart?.Invoke(__value2);
            }
            else if (AgentResponse is { } __value3)
            {
                agentResponse?.Invoke(__value3);
            }
            else if (AgentToolRequest is { } __value4)
            {
                agentToolRequest?.Invoke(__value4);
            }
            else if (AgentToolResponse is { } __value5)
            {
                agentToolResponse?.Invoke(__value5);
            }
            else if (ClientToolCall is { } __value6)
            {
                clientToolCall?.Invoke(__value6);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                StreamEnded,
                typeof(global::ElevenLabs.StreamEndedEvent),
                AgentChatResponsePart,
                typeof(global::ElevenLabs.AgentChatResponsePartClientEvent),
                AgentReasoningResponsePart,
                typeof(global::ElevenLabs.AgentReasoningResponsePartClientEvent),
                AgentResponse,
                typeof(global::ElevenLabs.AgentResponseClientEvent),
                AgentToolRequest,
                typeof(global::ElevenLabs.AgentToolRequestStreamedEvent),
                AgentToolResponse,
                typeof(global::ElevenLabs.AgentToolResponseStreamedEvent),
                ClientToolCall,
                typeof(global::ElevenLabs.ClientToolCallEvent),
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
        public bool Equals(Event other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.StreamEndedEvent?>.Default.Equals(StreamEnded, other.StreamEnded) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.AgentChatResponsePartClientEvent?>.Default.Equals(AgentChatResponsePart, other.AgentChatResponsePart) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.AgentReasoningResponsePartClientEvent?>.Default.Equals(AgentReasoningResponsePart, other.AgentReasoningResponsePart) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.AgentResponseClientEvent?>.Default.Equals(AgentResponse, other.AgentResponse) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.AgentToolRequestStreamedEvent?>.Default.Equals(AgentToolRequest, other.AgentToolRequest) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.AgentToolResponseStreamedEvent?>.Default.Equals(AgentToolResponse, other.AgentToolResponse) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.ClientToolCallEvent?>.Default.Equals(ClientToolCall, other.ClientToolCall)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(Event obj1, Event obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Event>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(Event obj1, Event obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Event o && Equals(o);
        }
    }
}
