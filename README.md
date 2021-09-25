# Esolang Web-runner

## About
A [Compiler Explorer](https://www.godbolt.org) like site running interpreters for esoteric languages.

## Layout

`esolang-webrunnner/Program.cs` is the main driver program. I think it renders the `esolang-webrunner/App.razor` page.
`App.razor` then in turn calls `esolang-webrunner/Shared/MainLayout.razor`.

`MainLayout.razor` specifies the page layout as it looks and accepts the 'body' content to render from `App.razor`. `MainLayout.razor` calls
on the other components it renders such as the NavMenu (`esolang-webrunner/Shared/NavMenu.razor`).

The `@body` in `MainLayout.razor` is the body content passed from `App.razor`, which in this case is a `<RouteView/>` component.
`RouteView` is responsible for rendering the correct page based on what URL the site is at.

Pages are defined in the `esolang-webrunner/Pages` sub-directory in separate .razor files. Each page razor file has the matching URL
defined at top (which is how `RouteView` knows how to render the page matching to a URL I'm assuming).

