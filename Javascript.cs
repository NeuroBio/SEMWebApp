
using Microsoft.JSInterop;
using System.Threading.Tasks;


public class PromptInterop

{

    /// <summary>

    /// Invokes a browser prompt and returns the user's input.

    /// </summary>

    public static Task<string> PromptAsync(string message) {

        return JSRuntime.Current.InvokeAsync<string>("JS.showPrompt",message);

	}
    public static Task BirdMatrixUpdate(int[] age, string[] color) {
      return JSRuntime.Current.InvokeAsync<Task>("JS.birdMatrixUpdate",age,color);
    }


}

