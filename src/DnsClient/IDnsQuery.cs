﻿using System.Net;
using System.Threading;
using System.Threading.Tasks;

namespace DnsClient
{
    /// <summary>
    /// Generic contract to query DNS endpoints. Implemented by <see cref="LookupClient"/>.
    /// </summary>
    public interface IDnsQuery
    {
        IDnsQueryResponse Query(string query, QueryType queryType);

        IDnsQueryResponse Query(string query, QueryType queryType, QueryClass queryClass);

        Task<IDnsQueryResponse> QueryAsync(string query, QueryType queryType);

        Task<IDnsQueryResponse> QueryAsync(string query, QueryType queryType, QueryClass queryClass);

        Task<IDnsQueryResponse> QueryAsync(string query, QueryType queryType, CancellationToken cancellationToken);

        Task<IDnsQueryResponse> QueryAsync(string query, QueryType queryType, QueryClass queryClass, CancellationToken cancellationToken);

        IDnsQueryResponse QueryReverse(IPAddress ipAddress);

        Task<IDnsQueryResponse> QueryReverseAsync(IPAddress ipAddress);

        Task<IDnsQueryResponse> QueryReverseAsync(IPAddress ipAddress, CancellationToken cancellationToken);
    }
}