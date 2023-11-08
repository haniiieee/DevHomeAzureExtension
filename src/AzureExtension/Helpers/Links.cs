﻿// Copyright (c) Microsoft Corporation and Contributors
// Licensed under the MIT license.

using Microsoft.VisualStudio.Services.WebApi;

namespace DevHomeAzureExtension.Helpers;

public class Links
{
    public static string GetLinkHref(ReferenceLinks links, string linkName)
    {
        if (links == null || links.Links == null
            || !links.Links.ContainsKey(linkName)
            || links.Links[linkName] == null)
        {
            return string.Empty;
        }

        if (links.Links[linkName] is not ReferenceLink linkRef)
        {
            return string.Empty;
        }

        return linkRef.Href;
    }
}
