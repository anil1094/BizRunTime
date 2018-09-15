using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Disposables;
using System.Reactive.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerProg.RX.Net_Program
{
    class Class2
    {
        static void Main(string[] args)
        {
            IObservable<T> Empty<T>()
            {
                return Observable.Create<T>(o =>
                {
                    o.OnCompleted();
                    return Disposable.Empty;
                });
            }
            IObservable<T> Return<T>(T value)
            {
                return Observable.Create<T>(o =>
                {
                    o.OnNext(value);
                    o.OnCompleted();
                    return Disposable.Empty;
                });
            }
            IObservable<T> Never<T>()
            {
                return Observable.Create<T>(o =>
                {
                    return Disposable.Empty;
                });
            }
            IObservable<T> Throws<T>(Exception exception)
            {
                return Observable.Create<T>(o =>
                {
                    o.OnError(exception);
                    return Disposable.Empty;
                });
            }

        }
        }
    }