import { Resolver } from "found-relay";
import React from "react";
import { Provider } from "react-redux";
import { Provider as RebassProvider } from "rebass";
import { injectGlobal } from "styled-components";

import colors from "../styles/colors";
import environment from "./environment/environment";
import Router from "./routing/router";
import store from "./store/store";

/* tslint:disable no-unused-expression */
injectGlobal`
  * { box-sizing: border-box; }
  body { min-height: 100%; height: 100%; margin: 0; }
  #app { height: inherit; }
  html { height: 100%; color: ${colors.$grey} }
`;
/* tslint:enable no-unused-expression */

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
