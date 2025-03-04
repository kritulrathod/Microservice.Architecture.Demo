﻿using Exchange.Rates.Contracts.Messages.Base;
using Exchange.Rates.Contracts.Models;

namespace Exchange.Rates.Contracts.Messages;

public interface ICoinCapAssetAccepted : IBaseContract
{
  string Id { get; }

  CoinCapAsset AssetData { get; }

  string Message { get; }
}
