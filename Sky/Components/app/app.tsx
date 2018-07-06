import { Resolver } from "found-relay";
import React from "react";
import { Provider } from "react-redux";
import { Provider as RebassProvider } from "rebass";

import environment from "./environment/environment";
import Router from "./routing/router";
import store from "./store/store";

const resolver = new Resolver(environment);

const App = () => (
  <Provider store={store}>
    <RebassProvider
      theme={{
        fonts: ["Montserrat", "sans-serif"]
      }}
    >
      <Router matchContext={{ store }} resolver={resolver} />
    </RebassProvider>
  </Provider>
);

export default App;
