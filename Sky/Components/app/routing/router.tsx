import { createConnectedRouter, createRender } from "found";

const RenderError = () => (): null => null;

export default createConnectedRouter({
  render: createRender({
    renderError: RenderError,
  }),
});
