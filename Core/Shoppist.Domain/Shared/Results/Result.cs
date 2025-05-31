using System.Collections.Immutable;

namespace Shoppist.Domain.Shared.Results;

public abstract class BaseResult<TResult>(ImmutableArray<ErrorResult> errors)
    where TResult : BaseResult<TResult>
{
    public ImmutableArray<ErrorResult> Errors { get; } = errors;

    public bool IsSuccess => Errors.Length == 0;

    public bool IsFailure => !IsSuccess;

    public static TResult CreateFailure(ImmutableArray<ErrorResult> errors) =>
        (Activator.CreateInstance(typeof(TResult), errors) as TResult)!;

    public static TResult CreateFailure(ErrorResult error) => CreateFailure([error]);
}

public class Result(ImmutableArray<ErrorResult> errors) : BaseResult<Result>(errors)
{
    public Result() : this([]) { }

    public static Result CreateSuccess() => new();
}

public class Result<TValue>(ImmutableArray<ErrorResult> errors) : BaseResult<Result<TValue>>(errors)
{
    public Result(TValue? value) : this([]) => Value = value;

    public TValue? Value { get; private set; }

    public static Result<TValue> CreateSuccess(TValue value) => new(value);

    public static Result<TValue> CreateSuccess() => new(default(TValue));
}