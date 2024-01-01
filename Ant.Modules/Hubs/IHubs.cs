﻿using Skender.Stock.Indicators;

namespace ShareInvest.Hubs;

public interface IHubs
{
    Task AddToGroupAsync(string groupName);

    Task RemoveFromGroupAsync(string groupName);

    Task TransmitMarkerAsync(object marker);

    Task TransmitFuturesQuoteAsync(Quote quote, bool moreThanBefore);

    Task TransmitConclusionInformationAsync(string code, string data);

    Task TransmitQuoteInformationAsync(string code, string data);

    Task TransmitOpenMessageAsync(string json);

    Task InstructToRenewAssetStatusAsync(string accNo);

    Task EventOccursInStockAsync(string code);

    Task SendMessageAsync(string image, string name, string dt, string message, string code, string token);
}