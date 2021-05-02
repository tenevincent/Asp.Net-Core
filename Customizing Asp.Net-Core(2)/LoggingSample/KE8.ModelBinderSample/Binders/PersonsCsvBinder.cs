using CsvHelper;
using KE8.ModelBinderSample.Models;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace KE8.ModelBinderSample.Binders
{
    public class PersonsCsvBinder : IModelBinder
    {
        public async Task BindModelAsync(ModelBindingContext bindingContext)
        {
            if (bindingContext == null)
            {
                return;
            }

            var modelName = bindingContext.ModelName;
            if (String.IsNullOrEmpty(modelName))
            {
                modelName = bindingContext.OriginalModelName;
            }
            if (String.IsNullOrEmpty(modelName))
            {
                return;
            }

            // Try to fetch the value of the argument by name
            var valueProviderResult = bindingContext.ValueProvider.GetValue(modelName);
            if (valueProviderResult == ValueProviderResult.None)
            {
                return;
            }

            bindingContext.ModelState.SetModelValue(modelName, valueProviderResult);

            var value = valueProviderResult.FirstValue;
            // Check if the argument value is null or empty
            if (String.IsNullOrEmpty(value))
            {
                return;
            }

            var stringReader = new StringReader(value);
            var reader = new CsvReader(stringReader, CultureInfo.InvariantCulture);

            var asyncModel = reader.GetRecordsAsync<Person>();
            var model = await asyncModel.ToListAsync();
            bindingContext.Result = ModelBindingResult.Success(model);
        }
    }


}
