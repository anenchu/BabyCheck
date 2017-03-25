using System.Collections.Generic;
using abgf.babycheck.frontend.model;

namespace abgf.babycheck.frontend.contracts
{
    public interface IRepository
    {
        List<Garment> GetGarmentsAsync();
    }
}
