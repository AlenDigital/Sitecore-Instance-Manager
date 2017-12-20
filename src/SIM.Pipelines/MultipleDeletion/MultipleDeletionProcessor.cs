﻿namespace SIM.Pipelines.MultipleDeletion
{
  using SIM.Pipelines.Processors;
  using Sitecore.Diagnostics.Base;
  using JetBrains.Annotations;

  public abstract class MultipleDeletionProcessor : Processor
  {
    #region Protected methods

    protected override sealed void Process([NotNull] ProcessorArgs args)
    {
      Assert.ArgumentNotNull(args, nameof(args));

      Process((MultipleDeletionArgs)args);
    }

    protected abstract void Process([NotNull] MultipleDeletionArgs args);

    #endregion
  }
}