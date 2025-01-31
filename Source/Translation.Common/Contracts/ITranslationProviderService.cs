﻿using System.Threading.Tasks;

using Translation.Common.Models.Requests.TranslationProvider;
using Translation.Common.Models.Responses.TranslationProvider;

namespace Translation.Common.Contracts
{
    public interface ITranslationProviderService
    {
        Task<TranslationProviderReadResponse> GetTranslationProvider(TranslationProviderReadRequest request);
        Task<TranslationProviderReadListResponse> GetTranslationProviders(TranslationProviderReadListRequest request);
        Task<TranslationProviderEditResponse> EditTranslationProvider(TranslationProviderEditRequest request);

    }
}