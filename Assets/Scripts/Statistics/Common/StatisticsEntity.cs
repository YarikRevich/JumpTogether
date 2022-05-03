using System.Collections;
using System.Collections.Generic;

public interface StatisticsEntity<T>
{
    void SendRequest(T model);
}
