using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using NLog;

namespace CorePractise01.Persistence.Commands
{
    public class BaseWriter
    {
        protected readonly IMapper _mapper;
        protected readonly PractiseContext _context;
        protected readonly Logger _logger = LogManager.GetCurrentClassLogger();

        public BaseWriter(IMapper mapper, PractiseContext context)
        {
            _mapper = mapper;
            _context = context;
        }

        protected virtual void SaveChanges()
        {
            try
            {
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                _logger.Error(e);
            }
        }
    }
}
