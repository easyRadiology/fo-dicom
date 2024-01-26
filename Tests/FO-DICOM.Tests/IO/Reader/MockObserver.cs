// Copyright (c) 2012-2023 fo-dicom contributors.
// Licensed under the Microsoft Public License (MS-PL).
#nullable disable

using FellowOakDicom.IO;
using FellowOakDicom.IO.Buffer;
using FellowOakDicom.IO.Reader;

namespace FellowOakDicom.Tests.IO.Reader
{

    public class MockObserver : IDicomReaderObserver
    {
        public MockObserver()
        {
        }

        public void OnElement(IByteSource source, DicomTag tag, DicomVR vr, IByteBuffer data, long offset)
        {
        }

        public void OnBeginSequence(IByteSource source, DicomTag tag, uint length, long offset)
        {
        }

        public void OnBeginSequenceItem(IByteSource source, uint length)
        {
        }

        public void OnEndSequenceItem()
        {
        }

        public void OnEndSequence()
        {
        }

        public void OnBeginFragmentSequence(IByteSource source, DicomTag tag, DicomVR vr, long offset)
        {
        }

        public void OnFragmentSequenceItem(IByteSource source, IByteBuffer data)
        {
        }

        public void OnEndFragmentSequence()
        {
        }
    }
}
