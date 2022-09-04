using Castle.DynamicProxy;
using Core.Security.Interceptors;
using FluentValidation;
using FluentValidation.Results;

namespace Core.Application.Pipelines.Validation
{
    public class ValidationTool
    {
        public class ValidationAspect : MethodInterception
        {
            private Type _validatorType;
            public ValidationAspect(Type validatorType)
            {
                if (!typeof(IValidator).IsAssignableFrom(validatorType))
                {
                    throw new System.Exception("Bu Bir Doğrulama Sınıfı Değildir");
                }

                _validatorType = validatorType;
            }
            protected override void OnBefore(IInvocation invocation)
            {
                var validator = (IValidator)Activator.CreateInstance(_validatorType);
                var entityType = _validatorType.BaseType.GetGenericArguments()[0];
                var entities = invocation.Arguments.Where(t => t.GetType() == entityType);
                foreach (var entity in entities)
                {
                    Validation.Validate(validator, entity);
                }
            }
        }
    }

    public static class Validation
    {
        public static void Validate(IValidator validator, object entity)
        {
            var context = new ValidationContext<object>(entity);
            var result = validator.Validate(context);
            if (!result.IsValid)
            {
                throw new ValidationException(result.Errors);
            }
        }
    }
}