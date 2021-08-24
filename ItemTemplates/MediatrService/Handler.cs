using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Microsoft.Extensions.Logging;

namespace $rootnamespace$.$servicename$
{
	/// <summary>
	/// $servicename$ Handler
	/// </summary>	
	public class $servicename$Handler : IRequestHandler<$servicename$Request, $servicename$Response>
	{
		private readonly ILogger<$servicename$Handler> logger;

		/// <summary>
        /// Constructor
        /// </summary>
        /// <param name="logger"></param>
		public $servicename$Handler(ILogger<$servicename$Handler> logger)
		{
			this.logger = logger;
		}

        /// <summary>
        /// Handler
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
		public async Task<$servicename$Response> Handle($servicename$Request request, CancellationToken cancellationToken)
		{
			throw new NotImplementedException();
		}
	}
}
