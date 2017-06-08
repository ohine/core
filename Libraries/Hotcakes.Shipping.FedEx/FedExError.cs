#region License

// Distributed under the MIT License
// ============================================================
// Copyright (c) 2016 Hotcakes Commerce, LLC
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy of this software 
// and associated documentation files (the "Software"), to deal in the Software without restriction, 
// including without limitation the rights to use, copy, modify, merge, publish, distribute, 
// sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is 
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in all copies or 
// substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR 
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, 
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE 
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER 
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, 
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN 
// THE SOFTWARE.

#endregion

using System;
using System.Xml;

namespace Hotcakes.Shipping.FedEx
{
    [Serializable]
    public class FedExError
    {
        private string _Code = string.Empty;
        private string _Message = string.Empty;
        private string _Type = string.Empty;

        public FedExError()
        {
        }

        public FedExError(XmlNode n)
        {
            ParseNode(n);
        }

        public string Code
        {
            get { return _Code; }
            set { _Code = value; }
        }

        public string Message
        {
            get { return _Message; }
            set { _Message = value; }
        }

        public string ErrorType
        {
            get { return _Type; }
            set { _Type = value; }
        }

        public void ParseNode(XmlNode n)
        {
            _Code = XmlHelper.ParseInnerText(n, "Code");
            _Message = XmlHelper.ParseInnerText(n, "Message");
            _Type = XmlHelper.ParseInnerText(n, "Type");
        }
    }
}