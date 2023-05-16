// Copyright (c) 2012-2023 fo-dicom contributors.
// Licensed under the Microsoft Public License (MS-PL).
#nullable disable

using FellowOakDicom.Imaging;
using FellowOakDicom.Imaging.LUT;
using System.Linq;
using Xunit;

namespace FellowOakDicom.Tests.Imaging.LUT
{

    [Collection(TestCollections.General)]
    public class ModalitySequenceLUTTest
    {
        #region Unit tests

        [Fact]
        public void ModalitySequenceLutReturnsCorrectMinimumValue()
        {
            var file = DicomFile.Open(TestData.Resolve("CR-ModalitySequenceLUT.dcm"));
            var options = GrayscaleRenderOptions.FromDataset(file.Dataset, 0);
            var lut = new ModalitySequenceLUT(options.ModalityLUTSequence.First());
            Assert.Equal(0, lut.MinimumOutputValue);
        }

        [Fact]
        public void ModalitySequenceLutReturnsCorrectMaximumValue()
        {
            var file = DicomFile.Open(TestData.Resolve("CR-ModalitySequenceLUT.dcm"));
            var options = GrayscaleRenderOptions.FromDataset(file.Dataset, 0);
            var lut = new ModalitySequenceLUT(options.ModalityLUTSequence.First());
            Assert.Equal(1023, lut.MaximumOutputValue);
        }

        #endregion
    }
}
