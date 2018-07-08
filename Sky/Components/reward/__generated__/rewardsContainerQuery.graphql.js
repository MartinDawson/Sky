/**
 * @flow
 * @relayHash 12b6593194e931b3711fa6937af1a2e6
 */

/* eslint-disable */

'use strict';

/*::
import type { ConcreteRequest } from 'relay-runtime';
export type rewardsContainerQueryVariables = {|
  accountNumber: number
|};
export type rewardsContainerQueryResponse = {|
  +rewards: ?$ReadOnlyArray<?{|
    +rewardType: string
  |}>
|};
*/


/*
query rewardsContainerQuery(
  $accountNumber: Int!
) {
  rewards(accountNumber: $accountNumber) {
    rewardType
    id
  }
}
*/

const node/*: ConcreteRequest*/ = (function(){
var v0 = [
  {
    "kind": "LocalArgument",
    "name": "accountNumber",
    "type": "Int!",
    "defaultValue": null
  }
],
v1 = [
  {
    "kind": "Variable",
    "name": "accountNumber",
    "variableName": "accountNumber",
    "type": "Int!"
  }
],
v2 = {
  "kind": "ScalarField",
  "alias": null,
  "name": "rewardType",
  "args": null,
  "storageKey": null
};
return {
  "kind": "Request",
  "operationKind": "query",
  "name": "rewardsContainerQuery",
  "id": null,
  "text": "query rewardsContainerQuery(\n  $accountNumber: Int!\n) {\n  rewards(accountNumber: $accountNumber) {\n    rewardType\n    id\n  }\n}\n",
  "metadata": {},
  "fragment": {
    "kind": "Fragment",
    "name": "rewardsContainerQuery",
    "type": "Query",
    "metadata": null,
    "argumentDefinitions": v0,
    "selections": [
      {
        "kind": "LinkedField",
        "alias": null,
        "name": "rewards",
        "storageKey": null,
        "args": v1,
        "concreteType": "Reward",
        "plural": true,
        "selections": [
          v2
        ]
      }
    ]
  },
  "operation": {
    "kind": "Operation",
    "name": "rewardsContainerQuery",
    "argumentDefinitions": v0,
    "selections": [
      {
        "kind": "LinkedField",
        "alias": null,
        "name": "rewards",
        "storageKey": null,
        "args": v1,
        "concreteType": "Reward",
        "plural": true,
        "selections": [
          v2,
          {
            "kind": "ScalarField",
            "alias": null,
            "name": "id",
            "args": null,
            "storageKey": null
          }
        ]
      }
    ]
  }
};
})();
// prettier-ignore
(node/*: any*/).hash = '894d1e9338e9cc87742d867800e9d026';
module.exports = node;
