using System.Text;

namespace ElevenLabs.IntegrationTests;

public partial class Tests
{
    internal static (short[] samples, int sampleRate, int channels) ReadWavPcm16(ReadOnlySpan<byte> data)
    {
        using var ms = new MemoryStream(data.ToArray(), writable: false);
        using var br = new BinaryReader(ms, Encoding.UTF8, leaveOpen: true);

        var riff = new string(br.ReadChars(4));
        if (riff != "RIFF")
        {
            throw new InvalidDataException("Not RIFF");
        }

        br.ReadInt32();
        var wave = new string(br.ReadChars(4));
        if (wave != "WAVE")
        {
            throw new InvalidDataException("Not WAVE");
        }

        ushort audioFormat = 1;
        ushort localChannels = 1;
        int localSampleRate = 16000;
        ushort bitsPerSample = 16;

        while (ms.Position < ms.Length)
        {
            if (ms.Length - ms.Position < 8)
            {
                break;
            }

            var id = new string(br.ReadChars(4));
            int size = br.ReadInt32();
            long next = ms.Position + size;

            if (id == "fmt ")
            {
                if (size < 16)
                {
                    throw new InvalidDataException("Bad fmt chunk");
                }

                audioFormat = br.ReadUInt16();
                localChannels = br.ReadUInt16();
                localSampleRate = br.ReadInt32();
                br.ReadInt32();
                br.ReadUInt16();
                bitsPerSample = br.ReadUInt16();

                if (next > ms.Position)
                {
                    br.ReadBytes((int)(next - ms.Position));
                }
            }
            else if (id == "data")
            {
                if (audioFormat != 1 || bitsPerSample != 16)
                {
                    throw new InvalidDataException("Expected PCM16");
                }

                var dataSize = size == 0 ? (int)(ms.Length - ms.Position) : size;
                var dataBytes = br.ReadBytes(dataSize);
                var samples = new short[dataBytes.Length / 2];
                Buffer.BlockCopy(dataBytes, 0, samples, 0, dataBytes.Length);
                return (samples, localSampleRate, localChannels);
            }
            else if (size > 0)
            {
                br.ReadBytes(size);
            }
        }

        throw new InvalidDataException("WAV data chunk not found");
    }
}
