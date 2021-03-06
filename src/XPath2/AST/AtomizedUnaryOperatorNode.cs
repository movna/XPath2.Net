﻿// Microsoft Public License (Ms-PL)
// See the file License.rtf or License.txt for the license details.

// Copyright (c) 2011, Semyon A. Chertkov (semyonc@gmail.com)
// All rights reserved.

namespace Wmhelp.XPath2.AST
{
    internal class AtomizedUnaryOperatorNode : UnaryOperatorNode
    {
        public AtomizedUnaryOperatorNode(XPath2Context context, UnaryOperator action, object node,
            XPath2ResultType resultType)
            : base(context, action, node, resultType)
        {
        }

        public override object Execute(IContextProvider provider, object[] dataPool)
        {
            object value = CoreFuncs.Atomize(this[0].Execute(provider, dataPool));
            if (value != Undefined.Value)
                return _unaryOper(provider, value);
            return Undefined.Value;
        }
    }
}