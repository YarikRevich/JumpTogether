using System.Collections;
using System.Collections.Generic;

public interface StatisticsEntity<T>
{
    IEnumerator SendRequest(T model);
}
