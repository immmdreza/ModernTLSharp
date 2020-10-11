using System;
using System.Collections.Generic;

namespace ModernTlSharp.TLSharp.Core.MTProto.Crypto
{
    public class Salt : IComparable<Salt>
    {
        private readonly int validSince;
        private readonly int validUntil;
        private readonly ulong salt;

        public Salt(int validSince, int validUntil, ulong salt)
        {
            this.validSince = validSince;
            this.validUntil = validUntil;
            this.salt = salt;
        }

        public int ValidSince => validSince;

        public int ValidUntil => validUntil;

        public ulong Value => salt;

        public int CompareTo(Salt other)
        {
            return validUntil.CompareTo(other.validSince);
        }
    }

    public class SaltCollection
    {
        private readonly SortedSet<Salt> salts;

        public void Add(Salt salt)
        {
            salts.Add(salt);
        }

        public int Count => salts.Count;
        // TODO: get actual salt and other...
    }

    public class GetFutureSaltsResponse
    {
        private readonly ulong requestId;
        private readonly int now;
        private readonly SaltCollection salts;

        public GetFutureSaltsResponse(ulong requestId, int now)
        {
            this.requestId = requestId;
            this.now = now;
        }

        public void AddSalt(Salt salt)
        {
            salts.Add(salt);
        }

        public ulong RequestId => requestId;

        public int Now => now;

        public SaltCollection Salts => salts;
    }
}
